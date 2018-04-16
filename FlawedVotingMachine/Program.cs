using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

public static class VotingSystem
{
    public static bool VotingStarted { get; set; } = false;
    public static int VoteType { get; set; } = 0;
    public static int successful_login_id { get; set; }
    public static bool successful_login_id_can_vote { get; set; }
}

namespace FlawedVotingMachine
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Assembly _assembly = Assembly.GetExecutingAssembly();

            //
            List<int> VoterList = new List<int>();
            List<int> AdminList = new List<int>();
            string VoterTable = "CREATE TABLE voter_list (voter_id int PRIMARY KEY, voted int DEFAULT 0)";
            string AdminTable = "CREATE TABLE voter_admins (admin_id int PRIMARY KEY)";
            string FiveCandidatesTable = "CREATE TABLE five_candidates (voter_id int PRIMARY KEY, " +
                "candidate_choice int, timestamp DATETIME DEFAULT CURRENT_TIMESTAMP)";
            string VariableChoiceTable = "CREATE TABLE variable_choice (voter_id int PRIMARY KEY, " +
                "candidate_one int DEFAULT 0, candidate_two int DEFAULT 0, candidate_three int DEFAULT 0, " +
                "candidate_four int DEFAULT 0, candidate_five int DEFAULT 0, " +
                "timestamp DATETIME DEFAULT CURRENT_TIMESTAMP)";
            string YesNoTable = "CREATE TABLE yes_no (voter_id int PRIMARY KEY, " +
                "voter_choice int DEFAULT 0, timestamp DATETIME DEFAULT CURRENT_TIMESTAMP)";

            StreamReader _VoterStreamReader = new StreamReader(_assembly.GetManifestResourceStream("FlawedVotingMachine.Voters.txt"));
            StreamReader _AdminStreamReader = new StreamReader(_assembly.GetManifestResourceStream("FlawedVotingMachine.Administrators.txt"));

            string line;
            while ((line = _VoterStreamReader.ReadLine()) != null)
            {
                VoterList.Add(Int32.Parse(line));
            }
            while((line = _AdminStreamReader.ReadLine()) != null)
            {
                AdminList.Add(Int32.Parse(line));
            }

            // Creating SQLite Database
            // Populating Tables
            SQLiteConnection.CreateFile("Voting.sqlite");
            SQLiteConnection v_dbconnection = new SQLiteConnection("Data Source=Voting.sqlite;Version=3");
            v_dbconnection.Open();

            SQLiteCommand command = new SQLiteCommand(VoterTable, v_dbconnection);
            command.ExecuteNonQuery();

            foreach(var id in VoterList)
            {
                command = new SQLiteCommand("INSERT INTO voter_list (voter_id) values (" + id + ")", v_dbconnection);
                command.ExecuteNonQuery();
            }

            command = new SQLiteCommand(AdminTable, v_dbconnection);
            command.ExecuteNonQuery();

            foreach(var id in AdminList)
            {
                command = new SQLiteCommand("INSERT INTO voter_admins (admin_id) values (" + id + ")", v_dbconnection);
                command.ExecuteNonQuery();
            }

            command = new SQLiteCommand(FiveCandidatesTable, v_dbconnection);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(VariableChoiceTable, v_dbconnection);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(YesNoTable, v_dbconnection);
            command.ExecuteNonQuery();            

            v_dbconnection.Close();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
