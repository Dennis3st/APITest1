using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITest1.Models
{
    public class Squad
    {
        public string id { get; set; }
        public string name { get; set; }
        public string number { get; set; }
        public string age { get; set; }
        public string position { get; set; }
        public string injured { get; set; }
        public string minutes { get; set; }
        public string appearences { get; set; }
        public string lineups { get; set; }
        public string substitute_in { get; set; }
        public string substitute_out { get; set; }
        public string substitutes_on_bench { get; set; }
        public string goals { get; set; }
        public string assists { get; set; }
        public string yellowcards { get; set; }
        public string yellowred { get; set; }
        public string redcards { get; set; }
    }

    public class Sidelined
    {
        public string name { get; set; }
        public string description { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string id { get; set; }
    }

    public class TransfersIn
    {
        public string id { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public string from_team { get; set; }
        public string team_id { get; set; }
        public string type { get; set; }
    }

    public class TransfersOut
    {
        public string id { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public string to_team { get; set; }
        public string team_id { get; set; }
        public string type { get; set; }
    }

    public class Statistic
    {
        public string rank { get; set; }
        public string wins { get; set; }
        public string wins_home { get; set; }
        public string wins_away { get; set; }
        public string draws { get; set; }
        public string draws_home { get; set; }
        public string draws_away { get; set; }
        public string losses { get; set; }
        public string losses_home { get; set; }
        public string losses_away { get; set; }
        public string clean_sheets { get; set; }
        public string clean_sheets_home { get; set; }
        public string clean_sheets_away { get; set; }
        public string goals { get; set; }
        public string goals_home { get; set; }
        public string goals_away { get; set; }
        public string goals_conceded { get; set; }
        public string goals_conceded_home { get; set; }
        public string goals_conceded_away { get; set; }
        public string avg_goals_per_game_scored { get; set; }
        public string avg_goals_per_game_scored_home { get; set; }
        public string avg_goals_per_game_scored_away { get; set; }
        public string avg_goals_per_game_conceded { get; set; }
        public string avg_goals_per_game_conceded_home { get; set; }
        public string avg_goals_per_game_conceded_away { get; set; }
        public string avg_first_goal_scored { get; set; }
        public string avg_first_goal_scored_home { get; set; }
        public string avg_first_goal_scored_away { get; set; }
        public string avg_first_goal_conceded { get; set; }
        public string avg_first_goal_conceded_home { get; set; }
        public string avg_first_goal_conceded_away { get; set; }
        public string failed_to_score { get; set; }
        public string failed_to_score_home { get; set; }
        public string failed_to_score_away { get; set; }
        public object biggest_defeat { get; set; }
        public object biggest_defeat_home { get; set; }
        public object biggest_defeat_away { get; set; }
        public string scoring_minutes_0_15_pct { get; set; }
        public string scoring_minutes_0_15_cnt { get; set; }
        public string scoring_minutes_15_30_pct { get; set; }
        public string scoring_minutes_15_30_cnt { get; set; }
        public string scoring_minutes_30_45_pct { get; set; }
        public string scoring_minutes_30_45_cnt { get; set; }
        public string scoring_minutes_45_60_pct { get; set; }
        public string scoring_minutes_45_60_cnt { get; set; }
        public string scoring_minutes_60_75_pct { get; set; }
        public string scoring_minutes_60_75_cnt { get; set; }
        public string scoring_minutes_75_90_pct { get; set; }
        public string scoring_minutes_75_90_cnt { get; set; }
    }

    public class RootObject
    {
        public string team_id { get; set; }
        public string is_national { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public string founded { get; set; }
        public string leagues { get; set; }
        public string venue_name { get; set; }
        public string venue_id { get; set; }
        public string venue_surface { get; set; }
        public string venue_address { get; set; }
        public string venue_city { get; set; }
        public string venue_capacity { get; set; }
        public string coach_name { get; set; }
        public string coach_id { get; set; }
        public List<Squad> squad { get; set; }
        public List<Sidelined> sidelined { get; set; }
        public List<TransfersIn> transfers_in { get; set; }
        public List<TransfersOut> transfers_out { get; set; }
        public List<Statistic> statistics { get; set; }
    }
}
