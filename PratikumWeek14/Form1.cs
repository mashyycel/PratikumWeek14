using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PratikumWeek14
{
    public partial class Team : Form
    {
        public Team()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand = new MySqlCommand();
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtTeam = new DataTable();
        DataTable dtMatch = new DataTable();
        DataTable dtWorst = new DataTable();
        int PosisiSekarang = 0;

        private void Team_Load(object sender, EventArgs e)
        {
            sqlQuery = "select t.team_name, concat(m.manager_name, ' (', n.nation, ')'), concat(t.home_stadium, ', ', t.city, ' (',t.capacity,')'), concat(p.player_name, ' ', max(j.Jumlah_Goal), ' (',a.Goal_penalty,')'), k.kartu from team t, manager m, nationality n, player p,player p2, dmatch d, (select p.player_id, p.player_name, count(d.`type`) as 'Jumlah_Goal' from dmatch d, player p where p.player_id = d.player_id and (d.`type` = 'GO' or 'GP') group by player_id) as j, (select p.player_id, p.player_name, count(d.`type`) as 'Goal_Penalty' from player p left join dmatch d on p.player_id = d.player_id and (d.`type` = 'GP') group by player_id) as a, (select concat(p.player_name, ', ', sum(if(d.`type` = 'CY',1,0)), ' Yellow Card and', sum(if(d.`type` = 'CR',1,0)) ,' Red Card') as kartu from player p, dmatch d, team t where p.player_id = d.player_id and d.team_id = t.team_id and t.team_name ='Arsenal' group by p.player_id order by sum(if(d.`type` = 'CY', 1, if(d.`type` = 'CR', 3,0))) desc limit 1) as k where n.nationality_id = m.nationality_id and m.manager_id = t.manager_id and p.player_id = d.player_id and j.player_name = p.player_name and (d.`type` = 'GO' or 'GP') and t.team_id = d.team_id and a.player_id = p.player_id group by t.team_id;" ;
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            lokasi(0);

          


            sqlQuery = " select match_date,if(m.team_home = t.team_id,'HOME',if(m.team_away = t.team_id,'AWAY',0)) AS 'home/away', concat(goal_home, ' - ', goal_away) as 'Score' from `match` m, team t where m.team_home = t.team_id and t.team_name = '" + lbl_teamName.Text + "' order by 1 desc limit 5; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatch);
            dgv_match.DataSource = dtMatch;



        }
        public void lokasi(int Posisi)
        {

            lbl_teamName.Text = dtTeam.Rows[Posisi][0].ToString();
            lbl_manager.Text = dtTeam.Rows[Posisi][1].ToString();
            lbl_stadium.Text = dtTeam.Rows[Posisi][2].ToString();
            lbl_top.Text = dtTeam.Rows[Posisi][3].ToString();
            lbl_worst.Text = dtTeam.Rows[Posisi][4].ToString();
            
            //if()

            PosisiSekarang = Posisi;
        }


        private void btn_first_Click(object sender, EventArgs e)
        {
            lokasi(0);
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                lokasi(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < dtTeam.Rows.Count - 1)
            {
                PosisiSekarang++;
                lokasi(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            lokasi(dtTeam.Rows.Count - 1);
        }
    }
}
