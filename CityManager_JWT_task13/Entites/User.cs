﻿namespace CityManager_JWT_task13.Entites
{
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public List<City>? Cities { get; set; }
    }
}
