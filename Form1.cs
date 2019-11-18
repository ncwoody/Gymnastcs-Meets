using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //class for the gymnast themselves- currently only for men's gymnastics, may change depending on my time ammount
        private class Gymnast
        {
            public string name;
            public string gym;
            public float fxscore;
            public Routine fxroutine;
            public float phscore;
            public Routine phroutine;
            public float srscore;
            public Routine srroutine;
            public float vtscore;
            public Routine vtroutine;
            public float pbscore;
            public Routine pbroutine;
            public float hbscore;
            public Routine hbroutine;
            public float aascore;
            public Routine aaroutine;

            public Gymnast(string name, string gym)
            {
                this.name = name;
                this.gym = gym;
            }
            //the score variables are for easier calculations, the routines are to interface with other classes
            public void AddScore(float score , string name)
            {
                switch (name)
                {
                    case "FX":
                        this.fxscore = score;
                        this.fxroutine = new Routine("FX", this, score);
                        break;
                    case "PH":
                        this.phscore = score;
                        this.phroutine = new Routine("PH", this, score);
                        break;
                    case "SR":
                        this.srscore = score;
                        this.srroutine = new Routine("SR", this, score);
                        break;
                    case "VT":
                        this.vtscore = score;
                        this.vtroutine = new Routine("VT", this, score);
                        break;
                    case "PB":
                        this.pbscore = score;
                        this.pbroutine = new Routine("PB", this, score);
                        break;
                    case "HB":
                        this.hbscore = score;
                        this.hbroutine = new Routine("HB", this, score);
                        break;
                    case "AA":
                        this.aascore = score;
                        this.aaroutine = new Routine("AA", this, score);
                        break;
                }
            }
            // calculating all-around score (the score variables are so this code is cleaner)
            public void calAA()
            {
                this.aascore = this.fxscore + this.phscore + this.srscore + this.vtscore + this.pbscore + this.hbscore;
                this.aaroutine = new Routine("AA", this, aascore);
            }
        }
        // class for each Event, stores a list of all the gymnasts and the routines that competed in the event
        private class Event
        {
            public string _name;
            public Routine[] routineList = new Routine[300]; 
            private int x = 0;

            public Event(string name)
            {
                this._name = name;
            }
            public void AddRoutine(Routine score)
            {
                routineList[x] = score;
                x++;
            }
            // is used to find the top placers in each event
            public void SortEvent()
            {

            }
        }
        // stores the list of all routines submitted for a specific competition
        private class Meet
        {
            public string meetName;
            public Event _floor;
            public Event _pommel;
            public Event _rings;
            public Event _vault;
            public Event _pbars;
            public Event _hbar;
            public Event _aaround;
            // used to initialize a meet that hasn't been completed yet
            public Meet(string name)
            {
                this.meetName = name;
            }
            // used to initialize a meet if the scores have already been entered to event objects
            public Meet(Event floor, Event pommel, Event rings, Event vault, Event pbars, Event hbar, Event aaround)
            {
                this._floor = floor;
                this._pommel = pommel;
                this._rings = rings;
                this._vault = vault;
                this._pbars = pbars;
                this._hbar = hbar;
                this._aaround = aaround;
            }
            // adds events to the meet.  This should be called either when the event is initialized or when adding scores from an event to the meet for the first time
            public void AddEvent(string name)
            {
                switch (name)
                {
                    case "FX":
                        this._floor = new Event(name);
                        break;
                    case "PH":
                        this._pommel = new Event(name);
                        break;
                    case "SR":
                        this._rings = new Event(name);
                        break;
                    case "VT":
                        this._vault = new Event(name);
                        break;
                    case "PB":
                        this._pbars = new Event(name);
                        break;
                    case "HB":
                        this._hbar = new Event(name);
                        break;
                    case "AA":
                        this._aaround = new Event(name);
                        break;
                }
            }
            // adds a gymnast to the event one routine at a time
            public void AddGymnast(Gymnast gymnast)
            {
                this._floor.AddRoutine(gymnast.fxroutine);
                this._pommel.AddRoutine(gymnast.phroutine);
                this._rings.AddRoutine(gymnast.srroutine);
                this._vault.AddRoutine(gymnast.vtroutine);
                this._pbars.AddRoutine(gymnast.pbroutine);
                this._hbar.AddRoutine(gymnast.hbroutine);
                this._aaround.AddRoutine(gymnast.aaroutine);
            }
        }
        // a class for the routine.  Essentially used to store the score and name of competitors in each event
        private class Routine
        {
            public Gymnast _competitor;
            private string _apparatus;
            private Sheet _result;
            public float _score;

            public Routine()
            {

            }
            // adding an event without a score sheet
            public Routine(string apparatus, Gymnast name, float score)
            {
                this._competitor = name;
                this._apparatus = apparatus;
                this._score = score;
            }
            // adding an event with a score sheet
            public Routine(string apparatus, Gymnast name, Sheet result, float score)
            {
                this._competitor = name;
                this._apparatus = apparatus;
                this._result = result;
                this._score = score;
            }
        }
        // a class for each gym- used for outputting the event data to a different file if you want a sepparate deliverable of just the scores of gymnasts from one specific gym
        private class Gym
        {
            private string _name;
            List<Gymnast> gymnasts = new List<Gymnast>();

            public Gym(string name)
            {
                this._name = name;
            }
            public void AddGymnast(Gymnast competitor)
            {
                gymnasts.Add(competitor);
            }
        }
        // used to add a score sheet to te routine class
        // the score sheet is designed to be useful for gymnasts to have a deeper understanding of why they got the score they did
        private class Sheet : Routine
        {
            private float _difficulty;
            private float _execution;
            private float _bonus;
            private float _score;
            private string _sheet;

            public Sheet(float difficulty, float execution, float bonus, float score, string sheet)
            {
                this._difficulty = difficulty;
                this._execution = execution;
                this._bonus = bonus;
                this._score = score;
                this._sheet = sheet;
            }
        }
        // a feature that may or may not be implemented which will be used to compare all the scores and sheets for a gymnast throughout the year and generate a report on how and where they improved
        private class History
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void AthleteName_TextChanged(object sender, EventArgs e)
        {

        }

        // making some accesable variables to help with generating classes
        Gymnast gymnast;
        Gymnast[] gymnastList = new Gymnast[300];
        public int i = 0;
        Meet meet;
        Meet[] meetList = new Meet[300];
        public int v = 0;
        Event madeEvent;

        public void AddGymnast_Click(object sender, EventArgs e)
        {
            // adding a gymnast to the list of gymnasts
            string name = athleteName.Text;
            string gym = athleteGym.Text;
            gymnast = new Gymnast(name, gym);
            athleteName.Text = "";
            athleteGym.Text = "";
            float fx;
            float ph;
            float sr;
            float vt;
            float pb;
            float hb;
            // these following lines read in the scores from the text boxes
            if (floorScore.Text == "")
            {
                fx = 0;
            }
            else
            {
                fx = float.Parse(floorScore.Text);
            }
            if (pommelScore.Text == "")
            {
                ph = 0;
            }
            else
            {
                ph = float.Parse(pommelScore.Text);
            }
            if (ringsScore.Text == "")
            {
                sr = 0;
            }
            else
            {
                sr = float.Parse(ringsScore.Text);
            }
            if (vaultScore.Text == "")
            {
                vt = 0;
            }
            else
            {
                vt = float.Parse(vaultScore.Text);
            }
            if (pbarScore.Text == "")
            {
                pb = 0;
            }
            else
            {
                pb = float.Parse(pbarScore.Text);
            }
            if (hbarScore.Text == "")
            {
                hb = 0;
            }
            else
            {
                hb = float.Parse(hbarScore.Text);
            }
            // adding the scores to the new gymnast class
            gymnast.AddScore(fx, "FX");
            gymnast.AddScore(ph, "PH");
            gymnast.AddScore(sr, "SR");
            gymnast.AddScore(vt, "VT");
            gymnast.AddScore(pb, "PB");
            gymnast.AddScore(hb, "HB");
            if (aaScore.Text == "")
            {
                gymnast.calAA();
            }
            else
            {
                gymnast.AddScore(float.Parse(aaScore.Text), "AA");
            }
            // some clean up to allow another gymnast to be created shortly
            floorScore.Text = "";
            pommelScore.Text = "";
            ringsScore.Text = "";
            vaultScore.Text = "";
            pbarScore.Text = "";
            hbarScore.Text = "";
            aaScore.Text = "";
            chooseGymnast.Items.Add(name);
            gymnastList[i] = gymnast;
            i++;
        }

        private void AthleteGym_TextChanged(object sender, EventArgs e)
        {

        }

        public void DisplayGymnast_Click(object sender, EventArgs e)
        {
            // gets the name of the gymnast we're looking for and searches for them out of the list of all the gymnasts created
            string name = chooseGymnast.Text;
            int k = 0;
            for (k = 0; k <=i; k++)
            {
                gymnast = gymnastList[k];
                if (gymnast.name == name)
                {
                    break;
                }
            }
            // displays the gymnast's information
            athleteGym.Text = gymnast.gym;
            athleteName.Text = gymnast.name;
            floorScore.Text = gymnast.fxscore.ToString();
            pommelScore.Text = gymnast.phscore.ToString();
            ringsScore.Text = gymnast.srscore.ToString();
            vaultScore.Text = gymnast.vtscore.ToString();
            pbarScore.Text = gymnast.pbscore.ToString();
            hbarScore.Text = gymnast.hbscore.ToString();
            aaScore.Text = gymnast.aascore.ToString();
        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void VaultScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void PbarScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void HbarScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void FloorScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void PommelScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void RingsScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void AaScore_TextChanged(object sender, EventArgs e)
        {

        }

        public void ChooseGymnast_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void ChooseMeet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MeetName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddMeet_Click(object sender, EventArgs e)
        {
            // adds a meet to the list of meets avaliable
            string name = meetName.Text;
            meet = new Meet(name);
            chooseMeet.Items.Add(name);
            meetList[v] = meet;
            v++;
            meetName.Text = "";
        }

        private void TopMeet_Click(object sender, EventArgs e)
        {
            // finds the specific meet from the name provided
            string competition = chooseMeet.Text;
            int k;
            if (competition == "")
            {
                return;
            }
            for (k = 0; k < v; k++)
            {
                meet = meetList[k];
                if (meet.meetName == competition)
                {
                    break;
                }
            }
            // this ugly statement finds the top competitor for each event
            topFloor.Text = meet._floor.routineList[0]._competitor.name + ": " + meet._floor.routineList[0]._competitor.fxscore.ToString();
            topPommel.Text = meet._pommel.routineList[0]._competitor.name + ": " + meet._pommel.routineList[0]._competitor.phscore.ToString();
            topRings.Text = meet._rings.routineList[0]._competitor.name + ": " + meet._rings.routineList[0]._competitor.srscore.ToString();
            topVault.Text = meet._vault.routineList[0]._competitor.name + ": " + meet._vault.routineList[0]._competitor.vtscore.ToString();
            topPbars.Text = meet._pbars.routineList[0]._competitor.name + ": " + meet._pbars.routineList[0]._competitor.pbscore.ToString();
            topHbar.Text = meet._hbar.routineList[0]._competitor.name + ": " + meet._hbar.routineList[0]._competitor.hbscore.ToString();
            topAA.Text = meet._aaround.routineList[0]._competitor.name + ": " + meet._aaround.routineList[0]._competitor.aascore.ToString();
        }

        private void TopFloor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TopPommel_TextChanged(object sender, EventArgs e)
        {

        }

        private void TopRings_TextChanged(object sender, EventArgs e)
        {

        }

        private void TopVault_TextChanged(object sender, EventArgs e)
        {

        }

        private void TopPbars_TextChanged(object sender, EventArgs e)
        {

        }

        private void TopHbar_TextChanged(object sender, EventArgs e)
        {

        }

        private void TopAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToMeet_Click(object sender, EventArgs e)
        {
            // finds the correct gymnast and meet
            string name = chooseGymnast.Text;
            int k = 0;
            if (name == "")
            {
                return;
            }
            for (k = 0; k <= i; k++)
            {
                gymnast = gymnastList[k];
                if (gymnast.name == name)
                {
                    break;
                }
            }
            string competition = chooseMeet.Text;
            if (competition == "")
            {
                return;
            }
            for (k = 0; k < v; k++)
            {
                meet = meetList[k];
                if (meet.meetName == competition)
                {
                    break;
                }
            }
            // adds the event and gymnast to the meet
            // only adds the event if there is not one already created
            if (meet._floor == null)
            {
                meet.AddEvent("FX");
            }
            if (meet._pommel == null)
            {
                meet.AddEvent("PH");
            }
            if (meet._rings == null)
            {
                meet.AddEvent("SR");
            }
            if (meet._vault == null)
            {
                meet.AddEvent("VT");
            }
            if (meet._pbars == null)
            {
                meet.AddEvent("PB");
            }
            if (meet._hbar == null)
            {
                meet.AddEvent("HB");
            }
            if (meet._aaround == null)
            {
                meet.AddEvent("AA");
            }
            meet.AddGymnast(gymnast);
        }
    }
}