using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace EmployeeManagementSystem
{
    internal class TeleBot
    {
        static TelegramBotClient client = new TelegramBotClient("5398239374:AAH8Yqo1wbucuouO29LThlbpYkJVcO0lJ3g");

        //connection string 
        public static SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection_String);
        public TeleBot() 
        {

            client.StartReceiving();
            client.OnMessage += Client_OnMessage;


        }

        String username;
        String password;
        String empNum;
        int level = 0;
        private void Client_OnMessage(object? sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if ((e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text && e.Message.Text == "/signout") && level != 0)
            {
                ///remove buttons on signout
                var x = client.SendTextMessageAsync(chatId: e.Message.Chat.Id, text: "***", replyMarkup: new ReplyKeyboardRemove());
                int y = x.Result.MessageId;
                client.DeleteMessageAsync(e.Message.Chat.Id, y);

                client.SendTextMessageAsync(e.Message.Chat.Id, "Good Bye 🖐");

                level = 0;

            }
            else if ((e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text && e.Message.Text == "/signin") && level == 0)
            {
                ///remove buttons before starting
                var x = client.SendTextMessageAsync(chatId: e.Message.Chat.Id, text: "***", replyMarkup: new ReplyKeyboardRemove());
                int y = x.Result.MessageId;
                client.DeleteMessageAsync(e.Message.Chat.Id, y);


                client.SendTextMessageAsync(e.Message.Chat.Id, "Welcome 👊 Type Any To Continue");
                level = 1;
            }
            else if ((e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text && e.Message.Text == "Main Menu") && level == 50)
            {
                level = 4;

                ///remove buttons when comming back to main menu
                var x = client.SendTextMessageAsync(chatId: e.Message.Chat.Id, text: "***", replyMarkup: new ReplyKeyboardRemove());
                int y = x.Result.MessageId;
                client.DeleteMessageAsync(e.Message.Chat.Id, y);


                client.SendTextMessageAsync(chatId: e.Message.Chat.Id, text: "Choose to Continue", replyMarkup: services);

            }
            else if ((e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text && e.Message.Text == "Main Menu") && level == 100)
            {
                level = 4;

                ///remove buttons when comming back to main menu
                var x = client.SendTextMessageAsync(chatId: e.Message.Chat.Id, text: "***", replyMarkup: new ReplyKeyboardRemove());
                int y = x.Result.MessageId;
                client.DeleteMessageAsync(e.Message.Chat.Id, y);


                client.SendTextMessageAsync(chatId: e.Message.Chat.Id, text: "Choose to Continue", replyMarkup: services);

            }

            else if ((e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text && e.Message.Text == "Main Menu") && level == 101)
            {
                level = 4;

                ///remove buttons when comming back to main menu
                var x = client.SendTextMessageAsync(chatId: e.Message.Chat.Id, text: "***", replyMarkup: new ReplyKeyboardRemove());
                int y = x.Result.MessageId;
                client.DeleteMessageAsync(e.Message.Chat.Id, y);


                client.SendTextMessageAsync(chatId: e.Message.Chat.Id, text: "Choose to Continue", replyMarkup: services);

            }


            else if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text && level == 1)
            {
                ///remove buttons before starting
                var x = client.SendTextMessageAsync(chatId: e.Message.Chat.Id, text: "***", replyMarkup: new ReplyKeyboardRemove());
                int y = x.Result.MessageId;
                client.DeleteMessageAsync(e.Message.Chat.Id, y);

                Thread.Sleep(500);

                client.SendTextMessageAsync(e.Message.Chat.Id, "Enter Username");
                level = 2;

            }
            else if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text && level == 2)
            {
                username = e.Message.Text;
                client.SendTextMessageAsync(e.Message.Chat.Id, "Enter Password");
                level = 3;

            }
            else if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text && level == 3)
            {
                password = e.Message.Text;


                con.Open();
                try
                {

                    SqlCommand Comm1 = new SqlCommand("select empPwd,empNum from users where empUsrName like @username;", con);
                    Comm1.Parameters.AddWithValue("@username", username);

                    SqlDataReader dr1 = Comm1.ExecuteReader();

                    if (dr1.Read())
                    {
                        byte[] salt = (byte[])dr1["empPwd"];
                        empNum = (String)dr1["empNum"];
                        dr1.Close();
                        Comm1.Dispose();

                        if (Hasher.MatchSHA1(salt, Hasher.GetSHA1(username, e.Message.Text)))
                        {
                            client.SendTextMessageAsync(chatId: e.Message.Chat.Id, text: "Logged In", replyMarkup: services);

                            Thread.Sleep(500);

                            level = 4;

                            client.SendTextMessageAsync(e.Message.Chat.Id, "Choose To Continue");




                        }
                        else
                        {
                            client.SendTextMessageAsync(e.Message.Chat.Id, "Password Not Matched,Try Again Or Sign Out");
                        }
                    }
                    else
                    {
                        client.SendTextMessageAsync(e.Message.Chat.Id, "Username Does Not Excist . Please Enter Username Correctly");
                        level = 2;

                    }
                    con.Close();
                }
                catch (Exception ex)
                {

                  

                }
                con.Close();
            }
            else if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text && level == 4)
            {
                if (e.Message.Text == "Attendance Management")
                {
                    con.Open();

                    try
                    {



                        //create a attendance record if not exist     

                        SqlCommand cmd = new SqlCommand("select * from attendance where empNum='" + empNum + "' and date='" + DateTime.Now.ToString("yyyy-MM-dd") + "';", con);
                        SqlDataReader dr2 = cmd.ExecuteReader();

                        if (dr2.Read())
                        {
                            cmd.Dispose();
                            dr2.Close();
                        }
                        else
                        {
                            cmd.Dispose();
                            dr2.Close();

                            String attenId = DateTime.Now.ToString("yyyyMMdd");
                            String checkIn = "-";
                            String checkOut = "-";

                            cmd = new SqlCommand("insert into attendance values('" + attenId + "','" + empNum + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + checkIn + "','" + checkOut + "');", con);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();



                        }



                        level = 50;

                        var a = client.SendTextMessageAsync(chatId: e.Message.Chat.Id, text: "***", replyMarkup: new ReplyKeyboardRemove());
                        int m = a.Result.MessageId;
                        client.DeleteMessageAsync(e.Message.Chat.Id, m);



                        client.SendTextMessageAsync(chatId: e.Message.Chat.Id, text: "***", replyMarkup: chks);
                    }
                    catch (Exception ex)
                    {



                    }

                    con.Close();
                }
                else if (e.Message.Text == "Leave Management")
                {
                    level = 100;

                    var a = client.SendTextMessageAsync(chatId: e.Message.Chat.Id, text: "***", replyMarkup: new ReplyKeyboardRemove());
                    int m = a.Result.MessageId;
                    client.DeleteMessageAsync(e.Message.Chat.Id, m);



                    client.SendTextMessageAsync(chatId: e.Message.Chat.Id, text: "***", replyMarkup: leaveM);

                }

            }
            else if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text && level == 50)
            {

                if (e.Message.Text == "CheckIn")
                {
                    con.Open();
                    try
                    {
                      
                        SqlCommand cmd = new SqlCommand("update attendance set checkIn='" + DateTime.Now.ToString("HH:mm:ss") + "'where empNum='" + empNum + "' and date='" + DateTime.Now.ToString("yyyy-MM-dd") + "';", con);
                        int y = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();

                        if (y == 1)
                        {
                            client.SendTextMessageAsync(e.Message.Chat.Id, "CheckedIn At " + DateTime.Now.ToString("HH:mm:ss"));
                        }
                        else
                        {
                            client.SendTextMessageAsync(e.Message.Chat.Id, "Something Went Wrong,Please Contact Admin");
                        }

                    }

                    catch (Exception ex)
                    {

                       
                    }
                    con.Close();
                }
                else if (e.Message.Text == "CheckOut")
                {
                    con.Open();
                    try
                    {
                  
                        SqlCommand cmd = new SqlCommand("update attendance set checkOut='" + DateTime.Now.ToString("HH:mm:ss") + "'where empNum='" + empNum + "' and date='" + DateTime.Now.ToString("yyyy-MM-dd") + "';", con);
                        int x = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();

                        if (x == 1)
                        {
                            client.SendTextMessageAsync(e.Message.Chat.Id, "CheckedOut At " + DateTime.Now.ToString("HH:mm:ss"));
                        }
                        else
                        {
                            client.SendTextMessageAsync(e.Message.Chat.Id, "Something Went Wrong,Please Contact Admin");
                        }

                    }

                    catch (Exception ex)
                    {
                       
                    }
                    con.Close();
                }

            }
            else if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text && level == 100)
            {


                if (e.Message.Text == "View Leave Status")
                {
                    level = 101;

                    var a = client.SendTextMessageAsync(chatId: e.Message.Chat.Id, text: "***", replyMarkup: new ReplyKeyboardRemove());
                    int m = a.Result.MessageId;
                    client.DeleteMessageAsync(e.Message.Chat.Id, m);



                    client.SendTextMessageAsync(chatId: e.Message.Chat.Id, text: "Select The Month", replyMarkup: months);


                }
                else if (e.Message.Text == "My Leave Balance")
                {

                    con.Open();
                    try
                    {
                        SqlCommand cmd = new SqlCommand("select lRecordyear,remMedical,remCasual,remFMLA,remTotal from users where empNum='" + empNum + "' and lRecordyear='" + DateTime.Now.Year + "'; ", con);
                        SqlDataReader dr1 = cmd.ExecuteReader();
                      //  level = 101;
                        if (dr1.Read())
                        {
                           

                            int LeaveRecordYear = (int)dr1["lRecordyear"];
                            int remainMedical = (int)dr1["remMedical"];
                            int remainCasual = (int)dr1["remCasual"];
                            int remainFMLA = (int)dr1["remFMLA"];
                            int remainTotal = (int)dr1["remTotal"];


                            ///could  change a bit 

                          
                            String message1 = "📆<b>Year: </b>" + LeaveRecordYear +"  🔹<b>Remaining Casuals: </b>" + remainCasual + "  🔹<b>Remaining Medicals: </b>" + remainMedical + "  🔹<b>Remaining FMLA: </b>" + remainFMLA +  "  🔹<b>Remaining Total: </b>" + remainTotal;

                            client.SendTextMessageAsync(e.Message.Chat.Id, message1, ParseMode.Html);

                            dr1.Close();
                            cmd.Dispose();

                        }
                        else { client.SendTextMessageAsync(e.Message.Chat.Id, "Something Went Wrong,Please Contact Admin"); }

                    }
                    catch (Exception ex)
                    {

                    }

                    con.Close();
                }

            }
            else if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text && level == 101)
            {
                con.Open();

                String month= e.Message.Text;
                String stDate = DateTime.Now.Year + "-" + month + "-%";

                try {
                    SqlCommand cmd = new SqlCommand("select startDate,endDate,leaveType,reason,status from leave where empNum='" + empNum + "' and startDate like'" + stDate + "'", con);

                    SqlDataReader sqlDataReader = cmd.ExecuteReader();


                    do
                    {

                        while (sqlDataReader.Read())
                        {
                            String StartDate = (String)sqlDataReader["startDate"];
                            String EndDate = (String)sqlDataReader["endDate"];
                            String leaveType = (String)sqlDataReader["leaveType"];
                            String Reason = (String)sqlDataReader["reason"];
                            String Status = (String)sqlDataReader["status"];

                           String message = "▶<b>From: </b>" + StartDate + "  🔹<b>To: </b>" + EndDate +"  🔹<b>Leave Type: </b>" + leaveType + "  🔹<b>Reason: </b>" + Reason + "  🔔<b>Status: </b>" + Status;

                           
                      
                               client.SendTextMessageAsync(e.Message.Chat.Id, message,ParseMode.Html);
                           





                        }
                    } while (sqlDataReader.NextResult());


                    sqlDataReader.Close();
                    cmd.Dispose();

                }catch (SqlException ex) { MessageBox.Show(e.Message.ToString()); }

                con.Close();
            }


        }




        //////////////////////////////

        ReplyKeyboardMarkup services = new(new[]
    {
        new KeyboardButton[] { "Attendance Management", "Leave Management" },

    })
        {
            ResizeKeyboard = true
        };



        ReplyKeyboardMarkup chks = new(new[]
{
        new KeyboardButton[] { "CheckIn", "CheckOut" },
         new KeyboardButton[] { "Main Menu" }

    })
        {
            ResizeKeyboard = true
        };


        ReplyKeyboardMarkup leaveM = new(new[]
{
        new KeyboardButton[] { "View Leave Status","My Leave Balance" },
          new KeyboardButton[] { "Main Menu" }

    })
        {
            ResizeKeyboard = true
        };

        ReplyKeyboardMarkup months = new(new[]
{
        new KeyboardButton[] { "01", "02","03","04","05","06"},
        new KeyboardButton[] { "07", "08","09","10","11","12"},
         new KeyboardButton[] { "Main Menu" }

    })
        {
            ResizeKeyboard = true
        };


    }

}
