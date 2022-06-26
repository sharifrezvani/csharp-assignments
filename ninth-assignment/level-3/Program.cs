using System;

namespace NinthAssignmentLevelThree
{

    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public Movie(int id, string title)
        {
            this.ID = id;
            this.Title = title;
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Movie> movieFranchises = new List<Movie>();
            List<Movie> movieTitles = new List<Movie>();

            movieFranchises.Add(new Movie(100, "James Bond"));
            movieFranchises.Add(new Movie(101, "Harry Potter"));
            movieFranchises.Add(new Movie(102, "Spider Man"));

            movieTitles.Add(new Movie(100, "Casino Royale"));
            movieTitles.Add(new Movie(100, "Quantum of Solace"));
            movieTitles.Add(new Movie(100, "Skyfall"));
            movieTitles.Add(new Movie(100, "Spectre"));
            movieTitles.Add(new Movie(100, "No Time to Die"));

            movieTitles.Add(new Movie(101, "and the Philosopher's Stone"));
            movieTitles.Add(new Movie(101, "and the Chamber of Secrets"));
            movieTitles.Add(new Movie(101, "and the Prisoner of Azkaban"));
            movieTitles.Add(new Movie(101, "and the Goblet of Fire"));
            movieTitles.Add(new Movie(101, "and the Order of the Phoenix"));
            movieTitles.Add(new Movie(101, "and the Half-Blood Prince"));
            movieTitles.Add(new Movie(101, "and the Deathly Hallows - Part 1"));
            movieTitles.Add(new Movie(101, "and the Deathly Hallows - Part 2"));

            movieTitles.Add(new Movie(102, "Homecoming"));
            movieTitles.Add(new Movie(102, "Far From Home"));
            movieTitles.Add(new Movie(102, "No Way Home"));


            var movies = movieTitles.Join(movieFranchises, movieTitle => movieTitle.ID, movieFranchise => movieFranchise.ID, (FirstMovie, SecondMovie) => new {movieID = FirstMovie.ID, movieName = $"{SecondMovie.Title} {FirstMovie.Title}"}).ToList();

            Console.WriteLine("\nMovies:\n");
            
            movies.ForEach(movie => Console.WriteLine($"ID: {movie.movieID}, Title: {movie.movieName}"));



        }
    }
}