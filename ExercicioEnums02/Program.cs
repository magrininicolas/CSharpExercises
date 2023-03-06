﻿using Course.Entities;
using System.Globalization;

namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      Comment c1 = new Comment("Have a nice trip!");
      Comment c2 = new Comment("Wow, that's awesome!");
      Post p1 = new Post(
        DateTime.ParseExact("21/06/2018 13:05:44", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
        "Traveling to New Zealand",
        "I'm going to visit this wonderful country!",
        12
      );
      p1.AddComment(c1);
      p1.AddComment(c2);

      Comment c3 = new Comment("Good Night!");
      Comment c4 = new Comment("May the force be with you!");
      Post p2 = new Post(
        DateTime.ParseExact("28/07/2018 23:14:19", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
        "Good night, guys!",
        "See ya 2morrow",
        5
      );
      p2.AddComment(c3);
      p2.AddComment(c4);
      
      System.Console.WriteLine(p1);
      System.Console.WriteLine(p2);
    }
  }
}