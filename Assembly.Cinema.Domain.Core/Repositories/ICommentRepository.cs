﻿using Assembly.Cinema.Domain.Core.Repositories;
using Cinema.Domain.Models;

public interface ICommentRepository : IRepository<Comment, int>
{
    public Comment GetCommentByUser(User user);

    public Comment GetCommentByMovie(Movie movie);
}
