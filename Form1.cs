namespace Mario_Kart_Punkterechner
{
    public partial class Form1 : Form
    {
        private string form;
        private War war;

        public Form1()
        {
            InitializeComponent();
            cbMode.SelectedIndex = 0;
        }

        private Race RaceValidation()
        {
            Race race;

            if (tbPlatzierungen.Text == "") throw new Exception("No placements were entered for team 1.");
            if (lbVorherigeRennen.Items.Count == 0) throw new Exception("A war hasn't been started yet.");

            switch (form)
            {
                case "6v6":
                case "5v5":
                case "4v4":
                case "3v3":
                case "2v2":
                    race = new Race(tbPlatzierungen.Text, form);
                    break;
                case "4v4...":
                    if(tbPlatzierungenT2.Text == "") throw new Exception("No placements were entered for team 2.");
                    race = new Race(tbPlatzierungen.Text, form, tbPlatzierungenT2.Text);
                    break;
                case "3v3...":
                    if (tbPlatzierungenT2.Text == "") throw new Exception("No placements were entered for team 2.");
                    if (tbPlatzierungenT3.Text == "") throw new Exception("No placements were entered for team 3.");
                    race = new Race(tbPlatzierungen.Text, form, tbPlatzierungenT2.Text, tbPlatzierungenT3.Text);
                    break;
                case "2v2...":
                    if (tbPlatzierungenT2.Text == "") throw new Exception("No placements were entered for team 2.");
                    if (tbPlatzierungenT3.Text == "") throw new Exception("No placements were entered for team 3.");
                    if (tbPlatzierungenT4.Text == "") throw new Exception("No placements were entered for team 4.");
                    if (tbPlatzierungenT5.Text == "") throw new Exception("No placements were entered for team 5.");
                    race = new Race(tbPlatzierungen.Text, form, tbPlatzierungenT2.Text, tbPlatzierungenT3.Text, tbPlatzierungenT4.Text, tbPlatzierungenT5.Text);
                    break;
                default:
                    throw new Exception("An unexpected error has occured.");
            }

            race.SetTrack(tbStrecke.Text);

            return race;
        }

        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbMode.SelectedIndex)
            {
                case 0:
                    form = "6v6";

                    tbPlatzierungen.Text = "1 2 3 4 5 6";

                    tbPlatzierungenT2.Visible = false;
                    tbPlatzierungenT3.Visible = false;
                    tbPlatzierungenT4.Visible = false;
                    tbPlatzierungenT5.Visible = false;

                    lbSpots2.Visible = false;
                    lbSpots3.Visible = false;
                    lbSpots4.Visible = false;
                    lbSpots5.Visible = false;

                    tbTeam3Tag.Visible = false;
                    tbTeam4Tag.Visible = false;
                    tbTeam5Tag.Visible = false;
                    tbTeam6Tag.Visible = false;

                    lbTeam3Tag.Visible = false;
                    lbTeam4Tag.Visible = false;
                    lbTeam5Tag.Visible = false;
                    lbTeam6Tag.Visible = false;
                    break;
                case 1:
                    form = "5v5";

                    tbPlatzierungen.Text = "1 2 3 4 5";

                    tbPlatzierungenT2.Visible = false;
                    tbPlatzierungenT3.Visible = false;
                    tbPlatzierungenT4.Visible = false;
                    tbPlatzierungenT5.Visible = false;

                    lbSpots2.Visible = false;
                    lbSpots3.Visible = false;
                    lbSpots4.Visible = false;
                    lbSpots5.Visible = false;

                    tbTeam3Tag.Visible = false;
                    tbTeam4Tag.Visible = false;
                    tbTeam5Tag.Visible = false;
                    tbTeam6Tag.Visible = false;

                    lbTeam3Tag.Visible = false;
                    lbTeam4Tag.Visible = false;
                    lbTeam5Tag.Visible = false;
                    lbTeam6Tag.Visible = false;
                    break;
                case 2:
                    form = "4v4";

                    tbPlatzierungen.Text = "1 2 3 4";

                    tbPlatzierungenT2.Visible = false;
                    tbPlatzierungenT3.Visible = false;
                    tbPlatzierungenT4.Visible = false;
                    tbPlatzierungenT5.Visible = false;

                    lbSpots2.Visible = false;
                    lbSpots3.Visible = false;
                    lbSpots4.Visible = false;
                    lbSpots5.Visible = false;

                    tbTeam3Tag.Visible = false;
                    tbTeam4Tag.Visible = false;
                    tbTeam5Tag.Visible = false;
                    tbTeam6Tag.Visible = false;

                    lbTeam3Tag.Visible = false;
                    lbTeam4Tag.Visible = false;
                    lbTeam5Tag.Visible = false;
                    lbTeam6Tag.Visible = false;
                    break;
                case 3:
                    form = "3v3";

                    tbPlatzierungen.Text = "1 2 3";

                    tbPlatzierungenT2.Visible = false;
                    tbPlatzierungenT3.Visible = false;
                    tbPlatzierungenT4.Visible = false;
                    tbPlatzierungenT5.Visible = false;

                    lbSpots2.Visible = false;
                    lbSpots3.Visible = false;
                    lbSpots4.Visible = false;
                    lbSpots5.Visible = false;

                    tbTeam3Tag.Visible = false;
                    tbTeam4Tag.Visible = false;
                    tbTeam5Tag.Visible = false;
                    tbTeam6Tag.Visible = false;

                    lbTeam3Tag.Visible = false;
                    lbTeam4Tag.Visible = false;
                    lbTeam5Tag.Visible = false;
                    lbTeam6Tag.Visible = false;
                    break;
                case 4:
                    form = "2v2";

                    tbPlatzierungen.Text = "1 2";

                    tbPlatzierungenT2.Visible = false;
                    tbPlatzierungenT3.Visible = false;
                    tbPlatzierungenT4.Visible = false;
                    tbPlatzierungenT5.Visible = false;

                    lbSpots2.Visible = false;
                    lbSpots3.Visible = false;
                    lbSpots4.Visible = false;
                    lbSpots5.Visible = false;

                    tbTeam3Tag.Visible = false;
                    tbTeam4Tag.Visible = false;
                    tbTeam5Tag.Visible = false;
                    tbTeam6Tag.Visible = false;

                    lbTeam3Tag.Visible = false;
                    lbTeam4Tag.Visible = false;
                    lbTeam5Tag.Visible = false;
                    lbTeam6Tag.Visible = false;
                    break;
                case 5:
                    form = "4v4...";

                    tbPlatzierungen.Text = "1 2 3 4";
                    tbPlatzierungenT2.Text = "5 6 7 8";

                    tbPlatzierungenT2.Visible = true;
                    tbPlatzierungenT3.Visible = false;
                    tbPlatzierungenT4.Visible = false;
                    tbPlatzierungenT5.Visible = false;

                    lbSpots2.Visible = true;
                    lbSpots3.Visible = false;
                    lbSpots4.Visible = false;
                    lbSpots5.Visible = false;

                    tbTeam3Tag.Visible = true;
                    tbTeam4Tag.Visible = false;
                    tbTeam5Tag.Visible = false;
                    tbTeam6Tag.Visible = false;

                    lbTeam3Tag.Visible = true;
                    lbTeam4Tag.Visible = false;
                    lbTeam5Tag.Visible = false;
                    lbTeam6Tag.Visible = false;
                    break;
                case 6:
                    form = "3v3...";

                    tbPlatzierungen.Text = "1 2 3";
                    tbPlatzierungenT2.Text = "4 5 6";
                    tbPlatzierungenT3.Text = "7 8 9";

                    tbPlatzierungenT2.Visible = true;
                    tbPlatzierungenT3.Visible = true;
                    tbPlatzierungenT4.Visible = false;
                    tbPlatzierungenT5.Visible = false;

                    lbSpots2.Visible = true;
                    lbSpots3.Visible = true;
                    lbSpots4.Visible = false;
                    lbSpots5.Visible = false;

                    tbTeam3Tag.Visible = true;
                    tbTeam4Tag.Visible = true;
                    tbTeam5Tag.Visible = false;
                    tbTeam6Tag.Visible = false;

                    lbTeam3Tag.Visible = true;
                    lbTeam4Tag.Visible = true;
                    lbTeam5Tag.Visible = false;
                    lbTeam6Tag.Visible = false;
                    break;
                case 7:
                    form = "2v2...";

                    tbPlatzierungen.Text = "1 2";
                    tbPlatzierungenT2.Text = "3 4";
                    tbPlatzierungenT3.Text = "5 6";
                    tbPlatzierungenT4.Text = "7 8";
                    tbPlatzierungenT5.Text = "9 10";

                    tbPlatzierungenT2.Visible = true;
                    tbPlatzierungenT3.Visible = true;
                    tbPlatzierungenT4.Visible = true;
                    tbPlatzierungenT5.Visible = true;

                    lbSpots2.Visible = true;
                    lbSpots3.Visible = true;
                    lbSpots4.Visible = true;
                    lbSpots5.Visible = true;

                    tbTeam3Tag.Visible = true;
                    tbTeam4Tag.Visible = true;
                    tbTeam5Tag.Visible = true;
                    tbTeam6Tag.Visible = true;

                    lbTeam3Tag.Visible = true;
                    lbTeam4Tag.Visible = true;
                    lbTeam5Tag.Visible = true;
                    lbTeam6Tag.Visible = true;
                    break;
            }
        }

        private void btnNewWar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbHeimTag.Text == "") throw new Exception("Missing home team tag.");
                if (tbGastTag.Text == "") throw new Exception("Missing guest team tag.");

                switch(form)
                {
                    case "6v6":
                    case "5v5":
                    case "4v4":
                    case "3v3":
                    case "2v2":
                        war = new War(tbHeimTag.Text, tbGastTag.Text, form);

                        lbTotalScore.Items.Clear();
                        lbLetztesRennen.Items.Clear();
                        lbVorherigeRennen.Items.Clear();
                        lbVorherigeRennen.Items.Add($"War: {tbHeimTag.Text} vs. {tbGastTag.Text}");
                        break;
                    case "4v4...":
                        war = new War(tbHeimTag.Text, tbGastTag.Text, form, tbTeam3Tag.Text);
                        lbTotalScore.Items.Clear();
                        lbLetztesRennen.Items.Clear();
                        lbVorherigeRennen.Items.Clear();
                        lbVorherigeRennen.Items.Add($"Mogi: {tbHeimTag.Text} vs. {tbGastTag.Text} vs. {tbTeam3Tag.Text}");
                        break;
                    case "3v3...":
                        war = new War(tbHeimTag.Text, tbGastTag.Text, form, tbTeam3Tag.Text, tbTeam4Tag.Text);
                        lbTotalScore.Items.Clear();
                        lbLetztesRennen.Items.Clear();
                        lbVorherigeRennen.Items.Clear();
                        lbVorherigeRennen.Items.Add($"Mogi: {tbHeimTag.Text} / {tbGastTag.Text} / {tbTeam3Tag.Text} / {tbTeam4Tag.Text}");
                        break;
                    case "2v2...":
                        war = new War(tbHeimTag.Text, tbGastTag.Text, form, tbTeam3Tag.Text, tbTeam4Tag.Text, tbTeam5Tag.Text, tbTeam6Tag.Text);
                        lbTotalScore.Items.Clear();
                        lbLetztesRennen.Items.Clear();
                        lbVorherigeRennen.Items.Clear();
                        lbVorherigeRennen.Items.Add($"Mogi: {tbHeimTag.Text} / {tbGastTag.Text} / {tbTeam3Tag.Text} / {tbTeam4Tag.Text} / {tbTeam5Tag.Text} / {tbTeam6Tag.Text}");
                        break;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "An error occured while trying to start a war");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Race race = RaceValidation();

                war.AddRace(race);

                int score = race.Score;
                int enemyScore = race.EnemyScore;

                switch (form)
                {
                    case "6v6":
                    case "5v5":
                    case "4v4":
                    case "3v3":
                    case "2v2":


                        lbLetztesRennen.Items.Clear();
                        lbLetztesRennen.Items.Add($"Score of race {lbVorherigeRennen.Items.Count}: {race.Placements}");
                        lbLetztesRennen.Items.Add("");
                        lbLetztesRennen.Items.Add($"{war.Home}\t{war.Guest}");
                        lbLetztesRennen.Items.Add($"{score}\t{enemyScore}\n");
                        lbLetztesRennen.Items.Add("");
                        lbLetztesRennen.Items.Add($"Difference: {score - enemyScore}");

                        pictureBox1.BackgroundImage = race.TrackImage;
                        string text;
                        if (race.Track != "") text = $"{lbVorherigeRennen.Items.Count} | {race.Score} - {race.EnemyScore} ({race.GetDifferenz(0)}) ({race.Track})";
                        else text = $"{lbVorherigeRennen.Items.Count} | {race.Score} - {race.EnemyScore} ({race.GetDifferenz(0)})";
                        lbVorherigeRennen.Items.Add(text);

                        lbTotalScore.Items.Clear();
                        lbTotalScore.Items.Add("Total score:");
                        lbTotalScore.Items.Add("");
                        lbTotalScore.Items.Add($"{war.Home}\t{war.Guest}");
                        lbTotalScore.Items.Add($"{war.GetFullScore()}\t{war.GetFullEnemyScore(1)}");
                        lbTotalScore.Items.Add("");
                        lbTotalScore.Items.Add($"Difference: {war.GetDifferenz(0)}");

                        tbPlatzierungen.Text = "";
                        tbStrecke.Text = "";
                        break;
                    case "4v4...":
                        int enemyScore2 = race.EnemyScore2;

                        int[] dif = new int[2];
                        dif[0] = score - enemyScore;
                        dif[1] = score - enemyScore2;

                        lbLetztesRennen.Items.Clear();
                        lbLetztesRennen.Items.Add($"Score of race {lbVorherigeRennen.Items.Count}: {race.Placements}");
                        lbLetztesRennen.Items.Add("");
                        lbLetztesRennen.Items.Add($"{war.Home}\t{war.Guest}\t{war.Team3}");
                        lbLetztesRennen.Items.Add($"{score}\t{enemyScore}\t{enemyScore2}");
                        lbLetztesRennen.Items.Add("");
                        lbLetztesRennen.Items.Add($"Difference {war.Home} - {war.Guest}: {dif[0]}");
                        lbLetztesRennen.Items.Add($"Difference {war.Home} - {war.Team3}: {dif[1]}");

                        pictureBox1.BackgroundImage = race.TrackImage;
                        if (race.Track != "") text = $"{lbVorherigeRennen.Items.Count} | {race.Score} / {race.EnemyScore} / {race.EnemyScore2} ({dif[0]} / {dif[1]}) ({race.Track})";
                        else text = $"{lbVorherigeRennen.Items.Count} | {race.Score} / {race.EnemyScore} / {race.EnemyScore2} ({dif[0]} / {dif[1]})";
                        lbVorherigeRennen.Items.Add(text);

                        lbTotalScore.Items.Clear();
                        lbTotalScore.Items.Add("Total score:");
                        lbTotalScore.Items.Add("");
                        lbTotalScore.Items.Add($"{war.Home}\t{war.Guest}\t{war.Team3}");
                        lbTotalScore.Items.Add($"{war.GetFullScore()}\t{war.GetFullEnemyScore(1)}\t{war.GetFullEnemyScore(2)}");
                        lbTotalScore.Items.Add("");
                        lbTotalScore.Items.Add($"Difference: {war.GetDifferenz(0)} / {war.GetDifferenz(1)}");

                        tbPlatzierungen.Text = "";
                        tbPlatzierungenT2.Text = "";
                        tbPlatzierungenT3.Text = "";
                        tbStrecke.Text = "";
                        break;
                    case "3v3...":
                        enemyScore2 = race.EnemyScore2;
                        int enemyScore3 = race.EnemyScore3;

                        dif = new int[3];
                        dif[0] = score - enemyScore;
                        dif[1] = score - enemyScore2;
                        dif[2] = score - enemyScore3;

                        lbLetztesRennen.Items.Clear();
                        lbLetztesRennen.Items.Add($"Score of race {lbVorherigeRennen.Items.Count}: {race.Placements}");
                        lbLetztesRennen.Items.Add("");
                        lbLetztesRennen.Items.Add($"{war.Home}\t{war.Guest}\t{war.Team3}\t{war.Team4}");
                        lbLetztesRennen.Items.Add($"{score}\t{enemyScore}\t{enemyScore2}\t{enemyScore3}");
                        lbLetztesRennen.Items.Add("");
                        lbLetztesRennen.Items.Add($"Difference {war.Home} - {war.Guest}: {dif[0]}");
                        lbLetztesRennen.Items.Add($"Difference {war.Home} - {war.Team3}: {dif[1]}");
                        lbLetztesRennen.Items.Add($"Difference {war.Home} - {war.Team4}: {dif[2]}");

                        pictureBox1.BackgroundImage = race.TrackImage;
                        if (race.Track != "") text = $"{lbVorherigeRennen.Items.Count} | {race.Score} / {race.EnemyScore} / {race.EnemyScore2} / {race.EnemyScore3} ({dif[0]} / {dif[1]} / {dif[2]}) ({race.Track})";
                        else text = $"{lbVorherigeRennen.Items.Count} | {race.Score} / {race.EnemyScore} / {race.EnemyScore2} / {race.EnemyScore3} ({dif[0]} / {dif[1]} / {dif[2]})";
                        lbVorherigeRennen.Items.Add(text);

                        lbTotalScore.Items.Clear();
                        lbTotalScore.Items.Add("Total score:");
                        lbTotalScore.Items.Add("");
                        lbTotalScore.Items.Add($"{war.Home}\t{war.Guest}\t{war.Team3}");
                        lbTotalScore.Items.Add($"{war.GetFullScore()}\t{war.GetFullEnemyScore(1)}\t{war.GetFullEnemyScore(2)}");
                        lbTotalScore.Items.Add("");
                        lbTotalScore.Items.Add($"Difference: {war.GetDifferenz(0)} / {war.GetDifferenz(1)} / {war.GetDifferenz(2)}");

                        tbPlatzierungen.Text = "";
                        tbPlatzierungenT2.Text = "";
                        tbPlatzierungenT3.Text = "";
                        tbPlatzierungenT4.Text = "";
                        tbStrecke.Text = "";
                        break;
                    case "2v2...":
                        enemyScore2 = race.EnemyScore2;
                        enemyScore3 = race.EnemyScore3;
                        int enemyScore4 = race.EnemyScore4;
                        int enemyScore5 = race.EnemyScore5;

                        dif = new int[5];
                        dif[0] = score - enemyScore;
                        dif[1] = score - enemyScore2;
                        dif[2] = score - enemyScore3;
                        dif[3] = score - enemyScore4;
                        dif[4] = score - enemyScore5;

                        lbLetztesRennen.Items.Clear();
                        lbLetztesRennen.Items.Add($"Score of race {lbVorherigeRennen.Items.Count}: {race.Placements}");
                        lbLetztesRennen.Items.Add("");
                        lbLetztesRennen.Items.Add($"{war.Home}\t{war.Guest}\t{war.Team3}\t{war.Team4}\t{war.Team5}\t{war.Team6}");
                        lbLetztesRennen.Items.Add($"{score}\t{enemyScore}\t{enemyScore2}\t{enemyScore3}\t{enemyScore4}\t{enemyScore5}");
                        lbLetztesRennen.Items.Add("");
                        lbLetztesRennen.Items.Add($"Difference {war.Home} - {war.Guest}: {dif[0]}");
                        lbLetztesRennen.Items.Add($"Difference {war.Home} - {war.Team3}: {dif[1]}");
                        lbLetztesRennen.Items.Add($"Difference {war.Home} - {war.Team4}: {dif[2]}");
                        lbLetztesRennen.Items.Add($"Difference {war.Home} - {war.Team5}: {dif[3]}");
                        lbLetztesRennen.Items.Add($"Difference {war.Home} - {war.Team6}: {dif[4]}");

                        pictureBox1.BackgroundImage = race.TrackImage;
                        if (race.Track != "") text = $"{lbVorherigeRennen.Items.Count} | {race.Score} / {race.EnemyScore} / {race.EnemyScore2} / {race.EnemyScore3} / {race.EnemyScore4} / {race.EnemyScore5} ({dif[0]} / {dif[1]} / {dif[2]} / {dif[3]} / {dif[4]}) ({race.Track})";
                        else text = $"{lbVorherigeRennen.Items.Count} | {race.Score} / {race.EnemyScore} / {race.EnemyScore2} / {race.EnemyScore3} / {race.EnemyScore4} / {race.EnemyScore5} ({dif[0]} / {dif[1]} / {dif[2]} / {dif[3]} / {dif[4]})";
                        lbVorherigeRennen.Items.Add(text);

                        lbTotalScore.Items.Clear();
                        lbTotalScore.Items.Add("Total score:");
                        lbTotalScore.Items.Add("");
                        lbTotalScore.Items.Add($"{war.Home}\t{war.Guest}\t{war.Team3}\t{war.Team4}\t{war.Team5}\t{war.Team6}");
                        lbTotalScore.Items.Add($"{war.GetFullScore()}\t{war.GetFullEnemyScore(1)}\t{war.GetFullEnemyScore(2)}\t{war.GetFullEnemyScore(3)}\t{war.GetFullEnemyScore(4)}\t{war.GetFullEnemyScore(5)}");
                        lbTotalScore.Items.Add("");
                        lbTotalScore.Items.Add($"Difference: {war.GetDifferenz(0)} / {war.GetDifferenz(1)} / {war.GetDifferenz(2)} / {war.GetDifferenz(3)} / {war.GetDifferenz(4)}");

                        tbPlatzierungen.Text = "";
                        tbPlatzierungenT2.Text = "";
                        tbPlatzierungenT3.Text = "";
                        tbPlatzierungenT4.Text = "";
                        tbPlatzierungenT5.Text = "";
                        tbStrecke.Text = "";
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "An error occured while trying to add the race");
            }
        }
    }
}