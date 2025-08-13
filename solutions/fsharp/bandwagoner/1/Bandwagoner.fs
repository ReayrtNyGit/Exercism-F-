module Bandwagoner

// TODO: please define the 'Coach' record type

// TODO: please define the 'Stats' record type

// TODO: please define the 'Team' record type

type Coach = {
    Name: string
    FormerPlayer: bool
}

type Stats = {
    Wins: int
    Losses: int
}

type Team = {
    Name: string
    Coach: Coach
    Stats: Stats
}

let createCoach (name: string) (formerPlayer: bool): Coach =
    { Name = name
      FormerPlayer = formerPlayer }

let createStats(wins: int) (losses: int): Stats =
   { Wins = wins
     Losses = losses }

let createTeam(name: string) (coach: Coach)(stats: Stats): Team =
  {Name = name 
   Coach = coach
   Stats = stats}

let replaceCoach(team: Team) (coach: Coach): Team =
   { team with Coach = coach }

let isSameTeam(homeTeam: Team) (awayTeam: Team): bool =
   homeTeam = awayTeam

let rootForTeam(team: Team): bool =
    let coach = team.Coach
    let stats = team.Stats
    (coach.Name = "Gregg Popovich")
    || coach.FormerPlayer
    || (team.Name = "Chicago Bulls")
    || (stats.Wins >= 60)
    || (stats.Losses > stats.Wins)
