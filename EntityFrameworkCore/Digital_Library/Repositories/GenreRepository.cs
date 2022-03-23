using System;
using System.Collections.Generic;
using System.Linq;
using Digital_Library.Models;


namespace Digital_Library.Repositories
{
    class GenreRepository
    {
        public Genre SelectGenreById(int genreId, AppContext db)
        {
            return db.Genres.FirstOrDefault(genre => genre.Id == genreId);
        }

        public List<Genre> SelectAllGenres(AppContext db)
        {
            return db.Genres.ToList();
        }

        public void AddGenre(Genre genre, AppContext db)
        {
            db.Genres.Add(genre);
            db.SaveChanges();
        }

        public void RemoveGenre(Genre genre, AppContext db)
        {
            db.Genres.Remove(genre);
            db.SaveChanges();
        }
    }
}
