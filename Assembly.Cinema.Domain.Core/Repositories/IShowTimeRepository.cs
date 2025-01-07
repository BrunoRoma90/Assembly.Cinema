﻿using Assembly.Cinema.Domain.Core.IRepository;
using Cinema.Domain.Models;

public interface IShowTimeRepository : IRepository<Showtime, int>
{
    public Showtime GetShowtimeByMovie(Movie movie);

    public Showtime GetShowtimeByCinemaRoom(CinemaRoom cinemaRoom);
}