﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITProject_Battleships.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ITProject_Battleships.Data
{
    public class DummyDataPlayer
    {
        //public List<Player> Get(List<Challenge> challenges)
        public List<Player> Get()
        {
            var list = new List<Player>();
            list.Add(new Player()
            {
                Email = "player1@battleship.com",
                Password = "player1",
                CreatedUserData = new DateTime(2020, 08, 25, 10, 30, 45),
                LastLogin = new DateTime(2020, 09, 15, 17, 30, 25),
                Nickname = "pl1",
                BattlesWon = 2,
                BattlesLost = 3,
                BattlesDraw = 0,
                ProfilePicture = "http=battleships/users/players/profiles/player1.jpg",
                Description = "Player 1 dummy data",
                //Challenges = new List<Challenge>()
            });

            list.Add(new Player()
            {
                Email = "player2@battleship.com",
                Password = "player2",
                CreatedUserData = new DateTime(2020, 08, 30, 13, 09, 45),
                LastLogin = new DateTime(2020, 09, 01, 07, 30, 05),
                Nickname = "pl2",
                BattlesWon = 3,
                BattlesLost = 1,
                BattlesDraw = 1,
                ProfilePicture = "http=battleships/users/players/profiles/player2.jpg",
                Description = "Player 2 dummy data",
                //Challenges = new List<Challenge>()
            });

            list.Add(new Player()
            {                    
                Email = "player3@battleship.com",
                Password = "player3",
                CreatedUserData = new DateTime(2020, 08, 15, 12, 10, 45),
                LastLogin = new DateTime(2020, 09, 30, 17, 30, 25),
                Nickname = "pl3",
                BattlesWon = 0,
                BattlesLost = 0,
                BattlesDraw = 0,
                ProfilePicture = "",
                Description = "Player 3 dummy data",
                //Challenges = new List<Challenge>()
            });

            list.Add(new Player()
            {
                Email = "player4@battleship.com",
                Password = "player4",
                CreatedUserData = new DateTime(2020, 10, 05, 10, 00, 00),
                LastLogin = new DateTime(2020, 10, 05, 10, 00, 00),
                Nickname = "pl4",
                BattlesWon = 0,
                BattlesLost = 0,
                BattlesDraw = 0,
                ProfilePicture = "http=battleships/users/players/profiles/player4.jpg",
                Description = "Player 4 dummy data",
                //Challenges = new List<PlayerChallenge>()
            });

            return list;                
        }
    }
}

