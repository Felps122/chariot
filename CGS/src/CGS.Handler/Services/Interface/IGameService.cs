﻿namespace CGS.Handler.Services.Interface
{
    public interface IGameService
    {
        Task<string> ConnectPlayer(string gameId, string userId, string socketId);

        Task<string> Move(string gameId, string userId, string moveStmt);
    }
}