using MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MoviesApi.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class UpdateMovieCommandHandler
    {
        private readonly MovieContext _context;

        public UpdateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateMovieCommand command)
        {
            var value = await _context.Movies.FindAsync(command.MovieId);
            value.Rating = command.Rating;
            value.Status = command.Status;
            value.CoverImageUrl = command.CoverImageUrl;
            value.Duration = command.Duration;
            value.CreatedYear = command.CreatedYear;
            value.Description = command.Description;
            value.RelaseDate = command.RelaseDate;
            value.MovieTitle = command.MovieTitle;
            await _context.SaveChangesAsync();
        }
    }
}
