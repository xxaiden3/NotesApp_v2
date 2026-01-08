using FontAwesome.Sharp;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing.Text;

namespace NotesApp.Data
{
    public static class DatabaseHelper
    {
        public static readonly string connectionString = @"Data Source=Data\Notes.db;Version=3;";

        public static void Initialize()
        {
            //Tablo oluştur
            #region
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string sql = @"
                CREATE TABLE IF NOT EXISTS Notes (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Title TEXT,
                    Content TEXT,
                    Tags TEXT,
                    FontName TEXT,
                    FontSize INTEGER,
                    IsBold INTEGER,
                    TextColor INTEGER,
                    CreatedDate TEXT
                );";

                string Taggetir = @"CREATE TABLE IF NOT EXISTS ListItems ( Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Text TEXT NOT NULL);";

                string Remindertable = @"CREATE TABLE IF NOT EXISTS Reminders(Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Title TEXT NOT NULL, Description TEXT NOT NULL, ReminderDate TEXT NOT NULL,
                CreatedAt TEXT NOT NULL);";
                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.ExecuteNonQuery();
                }
                using (var cmd = new SQLiteCommand(Taggetir, con))
                {
                    cmd.ExecuteNonQuery();
                }
                using (var cmd = new SQLiteCommand(Remindertable, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            #endregion
        }

        //Notes
        #region
        //Not oluştur
        public static void AddNote(
            string title,
            string content,
            string tags,
            string fontName,
            float fontSize,
            bool isBold,
            int textColor)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string sql = @"
                INSERT INTO Notes
                (Title, Content,Tags, FontName, FontSize, IsBold, TextColor, CreatedDate)
                VALUES
                (@Title, @Content, @Tags ,@FontName, @FontSize, @IsBold, @TextColor, @Date);";

                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Content", content);
                    cmd.Parameters.AddWithValue("@Tags", tags);
                    cmd.Parameters.AddWithValue("@FontName", fontName);
                    cmd.Parameters.AddWithValue("@FontSize", fontSize);
                    cmd.Parameters.AddWithValue("@IsBold", isBold ? 1 : 0);
                    cmd.Parameters.AddWithValue("@TextColor", textColor);
                    cmd.Parameters.AddWithValue("@Date",
                        DateTime.Now.ToString("yyyy-MM-dd"));

                    cmd.ExecuteNonQuery();
                }
            }
        }
        //Not Güncelleme
        public static void UpdateNote(
        int id,
        string title,
        string content,
        string tags,
        string fontName,
        float fontSize,
        bool isBold,
        int textColor)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string sql = @"
        UPDATE Notes SET
            Title = @Title,
            Content = @Content,
            Tags = @Tags,
            FontName = @FontName,
            FontSize = @FontSize,
            IsBold = @IsBold,
            TextColor = @TextColor
        WHERE Id = @Id;";

                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Content", content);
                    cmd.Parameters.AddWithValue("@Tags", tags);
                    cmd.Parameters.AddWithValue("@FontName", fontName);
                    cmd.Parameters.AddWithValue("@FontSize", fontSize);
                    cmd.Parameters.AddWithValue("@IsBold", isBold ? 1 : 0);
                    cmd.Parameters.AddWithValue("@TextColor", textColor);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        //Not silme
        public static void DeleteNote(int id)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                var cmd = new SQLiteCommand(
                    "DELETE FROM Notes WHERE Id=@Id", con);

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
        //Notları Getir
        public static DataTable GetNotes()
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string sql = "SELECT * FROM Notes ORDER BY Id DESC";

                using (var da = new SQLiteDataAdapter(sql, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        //Id'ye göre not getir
        public static DataRow GetNoteById(int id)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string sql = "SELECT * FROM Notes WHERE Id = @Id";

                using (var da = new SQLiteDataAdapter(sql, con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@Id", id);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt.Rows.Count > 0 ? dt.Rows[0] : null;
                }
            }
        }
        //Anasayfa için son iki notu getir
        public static DataTable GetLastTwoNotes()
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string sql = @"
            SELECT Title, Content, Tags , CreatedDate
            FROM Notes
            ORDER BY Id DESC
            LIMIT 2";

                using (var da = new SQLiteDataAdapter(sql, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        //Son 7 gün içinde oluşturulan notları getir
        public static DataTable GetNotesLast7Days()
        {
            DataTable dt = new DataTable();

            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string sql = @"
            SELECT *
            FROM Notes
            WHERE CreatedDate >= datetime('now','-7 day')
            ORDER BY CreatedDate DESC";

                using (var cmd = new SQLiteCommand(sql, con))
                using (var da = new SQLiteDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }
        //Son bir ayda oluşturulan notları getir
        public static DataTable GetNotesLastMonth()
        {
            DataTable dt = new DataTable();

            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string sql = @"
            SELECT *
            FROM Notes
            WHERE CreatedDate >= datetime('now','-1 month')
            ORDER BY CreatedDate DESC";

                using (var cmd = new SQLiteCommand(sql, con))
                using (var da = new SQLiteDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }
        //Notlarda arama
        public static DataTable SearchNotes(string title, string content, string tags)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string sql = @"SELECT * FROM Notes WHERE
            (@title = '' OR Title LIKE @titleLike)
        AND (@content = '' OR Content LIKE @contentLike)
        And (@tags = '' or tags LIKE @tagslike)
        ORDER BY Id DESC";

                using (var cmd = new SQLiteCommand(sql, con))
                {
                    title = title?.Trim() ?? "";
                    content = content?.Trim() ?? "";

                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@content", content);
                    cmd.Parameters.AddWithValue("@tags", tags);
                    cmd.Parameters.AddWithValue("@titleLike", "%" + title + "%");
                    cmd.Parameters.AddWithValue("@contentLike", "%" + content + "%");
                    cmd.Parameters.AddWithValue("@tagslike", "%" + tags + "%");

                    using (var da = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        #endregion
        //Reminder
        #region 
        public static DataTable GetRemindersByDate(DateTime date)
        {
            DataTable dt = new DataTable();

            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string sql = @"SELECT Id , Title, Description, CreatedAt FROM Reminders
                WHERE ReminderDate = @date
                ORDER BY CreatedAt DESC";

                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    using (var da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
        public static DataTable GetRemindersForHome()
        {
            DataTable dt = new DataTable();

            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string sql = @"Select Id , Title , Description , ReminderDate from Reminders";

                using (var cmd = new SQLiteCommand(sql, con))
                {
                    using (var da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
        public static void SaveReminder(string title, string desc, DateTime date)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string sql = @"
            INSERT INTO Reminders
            (Title, Description, ReminderDate, CreatedAt)
            VALUES
            (@title, @desc, @date, @created)
        ";

                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@desc", desc);
                    cmd.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@created", DateTime.Now.ToString("yyyy-MM-dd"));

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void DeleteReminder(int getid)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string sql = "DELETE FROM Reminders WHERE Id=@id";
                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", getid); //.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void UpdateReminder(
        int rid,
        string title,
        string description)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string sql = @"
        UPDATE Reminders SET
            Title = @title,
            Description = @description
            WHERE Id = @Id;";

                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@Id", rid);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
        //Tags
        #region
        public static DataTable GetListBoxItems()
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string sql = "SELECT Text FROM ListItems ORDER BY Id DESC";

                using (var da = new SQLiteDataAdapter(sql, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public static void addtag(string tagtext)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string sql = "INSERT INTO ListItems (Text) VALUES (@text)";
                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@text", tagtext); //.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
            }

        }
        public static void DeleteListTagItems(string tagtext)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string sql = "DELETE FROM ListItems WHERE Text=@TEXT";
                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@TEXT", tagtext); //.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

    }
}

