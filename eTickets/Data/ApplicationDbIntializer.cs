﻿using eTickets.Data.Enums;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class ApplicationDbIntializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
           using (var serviceScope=applicationBuilder.ApplicationServices.CreateScope())
            {
                var context=serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                //Movies
          //      if (!context.Movies.Any())
          //      {
          //          context.Movies.AddRange(new List<Movie>()
          //          {
          //              new Movie()
          //              {
          //                  Name="Life",
          //                  Description="This is the Life Movie Description",
          //                  Price=39.50,
          //                  ImageURL="https://dotnethow.net/images/movies/movie-3.jpeg",
          //                  StartDate=DateTime.Now.AddDays(-10),
          //                  EndDate=DateTime.Now.AddDays(10),
          //                  CinemaId=3,
          //                  ProducerId=3,
          //                  MovieCategory=MovieCategory.Documentory
          //              },
          //               new Movie()
          //                  {
          //                  Name="The Shawshank Redeption",
          //                  Description="This is the Shawshank Redeption Movie Description",
          //                  Price=29.50,
          //                  ImageURL="https://dotnethow.net/images/movies/movie-1.jpeg",
          //                  StartDate=DateTime.Now,
          //                  EndDate=DateTime.Now.AddDays(4),
          //                  CinemaId=1,
          //                  ProducerId=1,
          //                  MovieCategory=MovieCategory.Action
          //                  },
          //                new Movie()
          //                  {
          //                  Name="Ghost",
          //                  Description="This is the Ghost Movie Description",
          //                  Price=39.50,
          //                  ImageURL="https://dotnethow.net/images/movies/movie-4.jpeg",
          //                  StartDate=DateTime.Now,
          //                  EndDate=DateTime.Now.AddDays(7),
          //                  CinemaId=4,
          //                  ProducerId=4,
          //                  MovieCategory=MovieCategory.Horror
          //                  },

          //                 new Movie()
          //                  {
          //                  Name="Scoob",
          //                  Description="This is the Scoob Movie Description",
          //                  Price=27.75,
          //                  ImageURL="https://dotnethow.net/images/movies/movie-7.jpeg",
          //                  StartDate=DateTime.Now.AddDays(-10),
          //                  EndDate=DateTime.Now.AddDays(2),
          //                  CinemaId=1,
          //                  ProducerId=3,
          //                  MovieCategory=MovieCategory.Cartoon
          //                  },
          //                  new Movie()
          //                  {
          //                  Name="Cold Sales",
          //                  Description="This is the Cold Sales Movie Description",
          //                  Price=39.50,
          //                  ImageURL="https://dotnethow.net/images/movies/movie-8.jpeg",
          //                  StartDate=DateTime.Now.AddDays(-3),
          //                  EndDate=DateTime.Now.AddDays(20),
          //                  CinemaId=1,
          //                  ProducerId=5,
          //                  MovieCategory=MovieCategory.Drama
          //                  },

          //                   new Movie()
          //                  {
          //                  Name="Race",
          //                  Description="This is the Race Movie Description",
          //                  Price=39.50,
          //                  ImageURL="https://dotnethow.net/images/movies/movie-6.jpeg",
          //                  StartDate=DateTime.Now.AddDays(-10),
          //                  EndDate=DateTime.Now.AddDays(-5),
          //                  CinemaId=1,
          //                  ProducerId=2,
          //                  MovieCategory=MovieCategory.Documentory
          //                  }

          //          }
          //          );
          ////          context.SaveChanges();

          //      }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName="Producer-1",
                            ProfilePictureURL="https://dotnethow.net/images/producers/producer-1.jpeg",
                            Bio="This is the description of the first Producer"
                        },
                        new Producer()
                        {
                            FullName="Producer-2",
                            ProfilePictureURL="https://dotnethow.net/images/producers/producer-2.jpeg ",
                            Bio="This is the description of the second Producer"
                        },
                        new Producer()
                        {
                            FullName="Producer-3",
                            ProfilePictureURL="https://dotnethow.net/images/producers/producer-3.jpeg ",
                            Bio="This is the description of the third Producer"
                        },
                        new Producer()
                        {
                            FullName="Producer-4",
                            ProfilePictureURL="https://dotnethow.net/images/producers/producer-4.jpeg ",
                            Bio="This is the description of the fourth Producer"
                        },
                        new Producer()
                        {
                            FullName="Producer-5",
                            ProfilePictureURL="https://dotnethow.net/images/producers/producer-5.jpeg ",
                            Bio="This is the description of the fifth Producer"
                        }
                    }
                    );
                    context.SaveChanges();
                }
                //Cinemas
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name="Cinema-1",
                            Logo="https://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description="This is the description of the first Cinema"
                        },
                        new Cinema()
                        {
                            Name="Cinema-2",
                            Logo="https://dotnethow.net/images/cinemas/cinema-2.jpeg ",
                            Description="This is the description of the second Cinema"
                        },
                        new Cinema()
                        {
                            Name="Cinema-3",
                            Logo="https://dotnethow.net/images/cinemas/cinema-3.jpeg ",
                            Description="This is the description of the third Cinema"
                        },
                        new Cinema()
                        {
                            Name="Cinema-4",
                            Logo="https://dotnethow.net/images/cinemas/cinema-4.jpeg ",
                            Description="This is the description of the fourth Cinema"
                        },
                        new Cinema()
                        {
                            Name="Cinema-5",
                            Logo="https://dotnethow.net/images/cinemas/cinema-5.jpeg ",
                            Description="This is the description of the fifth Cinema"
                        },
                    }
                    );
                    context.SaveChanges();
                }
                //Actors_Movies
                //if (!context.Actors_Movies.Any())
                //{
                //    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                //    {
                //        new Actor_Movie()
                //        {
                //            ActorId=1,
                //            MovieId=1
                //        },
                //        new Actor_Movie()
                //        {
                //            ActorId=3,
                //            MovieId=1
                //        },
                //        new Actor_Movie()
                //        {
                //            ActorId=1,
                //            MovieId=2
                //        },
                //        new Actor_Movie()
                //        {
                //            ActorId=4,
                //            MovieId=2
                //        },
                //        new Actor_Movie()
                //        {
                //            ActorId=1,
                //            MovieId=3
                //        },
                //        new Actor_Movie()
                //        {
                //            ActorId=2,
                //            MovieId=3
                //        },
                //        new Actor_Movie()
                //        {
                //            ActorId=5,
                //            MovieId=3
                //        },
                //        new Actor_Movie()
                //        {
                //            ActorId=2,
                //            MovieId=4
                //        },
                //         new Actor_Movie()
                //        {
                //            ActorId=3,
                //            MovieId=4
                //        },
                //          new Actor_Movie()
                //        {
                //            ActorId=4,
                //            MovieId=4
                //        },
                //        new Actor_Movie()
                //        {
                //            ActorId=2,
                //            MovieId=5
                //        },
                //          new Actor_Movie()
                //        {
                //            ActorId=3,
                //            MovieId=5
                //        },
                //        new Actor_Movie()
                //        {
                //            ActorId=4,
                //            MovieId=5
                //        },
                //        new Actor_Movie()
                //        {
                //            ActorId=5,
                //            MovieId=5
                //        },
                //        new Actor_Movie()
                //        {
                //            ActorId=3,
                //            MovieId=6

                //        },
                //         new Actor_Movie()
                //        {
                //            ActorId=4,
                //            MovieId=6
                //        },
                //          new Actor_Movie()
                //        {
                //            ActorId=5,
                //            MovieId=6
                //        }
                //    }
                //        );
                //context.SaveChanges();

                //}
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName="Actor-1",
                            ProfilePictureURL="https://dotnethow.net/images/actors/actor-1.jpeg",
                            Bio="This is the description of the first Actor"
                        },
                        new Actor()
                        {
                            FullName="Actor-2",
                            ProfilePictureURL="https://dotnethow.net/images/actors/actor-2.jpeg ",
                            Bio="This is the description of the second Actor"
                        },
                        new Actor()
                        {
                            FullName="Actor-3",
                            ProfilePictureURL="https://dotnethow.net/images/actors/actor-3.jpeg ",
                            Bio="This is the description of the third Actor"
                        },
                        new Actor()
                        {
                            FullName="Actor-4",
                            ProfilePictureURL="https://dotnethow.net/images/actors/actor-4.jpeg ",
                            Bio="This is the description of the fourth Actor"
                        },
                        new Actor()
                        {
                            FullName="Actor-5",
                            ProfilePictureURL="https://dotnethow.net/images/actors/actor-5.jpeg ",
                            Bio="This is the description of the fifth Actor"
                        }
                    }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
