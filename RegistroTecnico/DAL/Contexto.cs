﻿using RegistroTecnico.Models;
using Microsoft.EntityFrameworkCore;




namespace RegistroTecnico.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    public DbSet<Tecnicos> Tecnicos { get; set; }
}