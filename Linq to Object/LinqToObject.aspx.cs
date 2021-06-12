using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq_to_Object
{
    public partial class LinqToObject : System.Web.UI.Page
    {

        public List<Football> GetFootballsData()
        {
            return new List<Football> {
                new Football {
                    FootballTeamName = "Liverpool",
                    Manager = "Roy Hodgson",
                    TeamCaption = "Steven Gerrard",
                    ChampionshipsWon = 18
                },
                new Football {
                    FootballTeamName = "ManUtd",
                    Manager = "ALex Ferguson",
                    TeamCaption = "Rio Ferdinand",
                    ChampionshipsWon = 18
                },
                new Football {
                    FootballTeamName = "Chelsea",
                    Manager = "Carlos Ancelotti",
                    TeamCaption = "Frank Lampard",
                    ChampionshipsWon = 4
                },
                new Football {
                    FootballTeamName = "Everton",
                    Manager = "David Moyes",
                    TeamCaption = "Phil Neville",
                    ChampionshipsWon = 9
                }
             };
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var football = GetFootballsData();
            this.GridView1.DataSource = football;
            this.GridView1.DataBind();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Football t = new Football();
            t.FootballTeamName = FootballTeamName.Text;
            t.Manager = Manager.Text;
            t.TeamCaption = TeamCaptain.Text;
            t.ChampionshipsWon = Convert.ToInt32(ChampionshipWons.Text);
            var obj = GetFootballsData();
            obj.Add(t);
            this.GridView1.DataSource = obj;
            this.GridView1.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            var obj = GetFootballsData();
            var newobj = obj.SingleOrDefault(x => x.FootballTeamName == FootballTeamName.Text);
            newobj.Manager = Manager.Text;
            newobj.TeamCaption = TeamCaptain.Text;
            newobj.ChampionshipsWon = Convert.ToInt32(ChampionshipWons.Text);
            this.GridView1.DataSource = obj;
            this.GridView1.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            var obj = GetFootballsData();
            var newobj = obj.SingleOrDefault(x => x.FootballTeamName == FootballTeamName.Text);
            obj.Remove(newobj);
            this.GridView1.DataSource = obj;
            this.GridView1.DataBind();
        }
    }
}