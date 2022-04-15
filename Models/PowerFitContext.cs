using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Models
{
    public partial class PowerFitContext : DbContext
    {
        public PowerFitContext()
        {
        }

        public PowerFitContext(DbContextOptions<PowerFitContext> options) : base(options)
        {
        }

        public virtual DbSet<Exercise> Exercises { get; set; }
        public virtual DbSet<SecondaryCategory> SecondaryCategories { get; set; }
        public virtual DbSet<ExerciseCategoryRelationship> ExerciseCategoryRelationship { get; set; }
        public virtual DbSet<FavoriteExercise> FavoriteExercises { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<PrimaryCategory> PrimaryCategories { get; set; }
        public virtual DbSet<PrimaryExerciseTagRelationship> PrimaryExerciseTagRelationship { get; set; }
        public virtual DbSet<ExerciseTag> ExerciseTag { get; set; }
        public virtual DbSet<SecondaryExerciseTagRelationship> SecondaryExerciseTagRelationship { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-P6DOUNS\\SQLSERVER;Initial Catalog=PowerFit;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercise>().HasData(
                new Exercise { ExerciseId = 1, ExerciseName = "Stražnji čučanj", EnglishExerciseName = "Back squat", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 2, ExerciseName = "Prednji čučanj", EnglishExerciseName = "Front squat", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 3, ExerciseName = "Iskorak", EnglishExerciseName = "Lunge", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 4, ExerciseName = "Zgib", EnglishExerciseName = "Pullup", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 5, ExerciseName = "Veslanje u natklonu", EnglishExerciseName = "Barbell row", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 6, ExerciseName = "Veslanje sa bučicom", EnglishExerciseName = "Dumbbell row", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 7, ExerciseName = "Konvencionalno mrtvo dizanje", EnglishExerciseName = "Conventional deadlift", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 8, ExerciseName = "Sumo mrtvo dizanje", EnglishExerciseName = "Sumo deadlift", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 9, ExerciseName = "Rumunjsko mrtvo dizanje", EnglishExerciseName = "Romanian deadlift", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 10, ExerciseName = "Triceps ekstenzija iznad glave", EnglishExerciseName = "Overhead triceps extension", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 11, ExerciseName = "Potisak s čela na ravnoj klupi", EnglishExerciseName = "Skullcrusher", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 12, ExerciseName = "Paralelno prodapadnje", EnglishExerciseName = "Dips", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 13, ExerciseName = "Stojeći pregib sa šipkom", EnglishExerciseName = "Barbell curl", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 14, ExerciseName = "Pregib s bučicama", EnglishExerciseName = "Dumbbell curl", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 15, ExerciseName = "Pregib bučicama sa neutralnim hvatom", EnglishExerciseName = "Hammer curl", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 16, ExerciseName = "Okomito veslanje", EnglishExerciseName = "Upright row", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 17, ExerciseName = "Potisak iznad glave", EnglishExerciseName = "Overhead press", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 18, ExerciseName = "Potisak iza glave", EnglishExerciseName = "Behind the neck press", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 19, ExerciseName = "Lateralno podizanje", EnglishExerciseName = "Lateral raise", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 20, ExerciseName = "Potisak sa ravne klupe", EnglishExerciseName = "Flat bench press", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 21, ExerciseName = "Potisak sa kose klupe", EnglishExerciseName = "Incline bench press", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 22, ExerciseName = "Razvlačenje bučicama na ravnoj klupi", EnglishExerciseName = "Flat dumbbell flys", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 23, ExerciseName = "Plank", EnglishExerciseName = "Plank", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 24, ExerciseName = "Bočni plank", EnglishExerciseName = "Side plank", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 25, ExerciseName = "V-podizanja", EnglishExerciseName = "V-situps", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 30, ExerciseName = "Fleksija vrata", EnglishExerciseName = "Neck curl", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 31, ExerciseName = "Ekstenzija vrata", EnglishExerciseName = "Neck extension", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 32, ExerciseName = "Pregib zapešća", EnglishExerciseName = "Wrist curl", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 33, ExerciseName = "Obrnuti pregib zapešća", EnglishExerciseName = "Reverse wrist curl", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 34, ExerciseName = "Pronacija zapešća", EnglishExerciseName = "Pronation", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 35, ExerciseName = "Supinacija zapešća", EnglishExerciseName = "Supination", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 36, ExerciseName = "Stojeće podizanje listova", EnglishExerciseName = "Standing calf raise", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 37, ExerciseName = "Sjedeće podizanje listova", EnglishExerciseName = "Seated calf raise", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 38, ExerciseName = "Podizanje listova na nožnoj preši", EnglishExerciseName = "Leg press calf raise", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 39, ExerciseName = "Farmerov hod", EnglishExerciseName = "Farmers walk", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 40, ExerciseName = "Log nabačaj i potisak", EnglishExerciseName = "Log clean and press", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 41, ExerciseName = "Yoke hod", EnglishExerciseName = "Yoke walk", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 42, ExerciseName = "Nabačaj i potisak",EnglishExerciseName="Clean and press", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 43, ExerciseName = "Nabačaj i izbačaj",EnglishExerciseName="Clean and jerk", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 44, ExerciseName = "Tabata",EnglishExerciseName="Tabata", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 45, ExerciseName = "Sprava za veslanje",EnglishExerciseName="Rowing machine", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 46, ExerciseName = "Stacionaran bicikl",EnglishExerciseName="Stationary bike", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 47, ExerciseName = "Trčanje",EnglishExerciseName="Running", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 48, ExerciseName = "Eliptični trenažer",EnglishExerciseName="Eliptical trainer", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 49, ExerciseName = "Trzaj",EnglishExerciseName="Snatch", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false },
                new Exercise { ExerciseId = 50, ExerciseName = "Z potisak",EnglishExerciseName="Z press", Image = null, Description = "", InsertDate = DateTime.Now, IsDeleted = false }

                ); 
            modelBuilder.Entity<PrimaryCategory>().HasData(
               new PrimaryCategory
               {
                   PrimaryCategoryId = 1,
                   Name = "Vježbe cijelog tijela"
                   //Snaga,izdržljivost,eksplozivnost...
               },
               new PrimaryCategory
               {
                   PrimaryCategoryId = 2,
                   Name = "Gornji dio tijela"
               },
               new PrimaryCategory
               {
                   PrimaryCategoryId = 3,
                   Name = "Donji dio tijela"
               },
               new PrimaryCategory
               {
                   PrimaryCategoryId = 4,
                   Name = "Kardio vježbe"
               });


            modelBuilder.Entity<SecondaryCategory>().HasData(
                new SecondaryCategory { SecondaryCategoryId = 1, Name = "Vrat", Description = "", PrimaryCategoryId = 2 }, 
                new SecondaryCategory { SecondaryCategoryId = 2, Name = "Ramena", Description = "Sastoje se od 3 dijela(tzv. glave) - prednji, lateralni i stražnji.", PrimaryCategoryId = 2 } , 
                new SecondaryCategory { SecondaryCategoryId = 3, Name = "Prsa", Description = "Sastoje se od dva mišića - gornji dio (pectoralis minor) i donji dio (pectoralis major).", PrimaryCategoryId = 2 }, 
                new SecondaryCategory { SecondaryCategoryId = 4, Name = "Leđa", Description = "Najveća skupina mišiča u gornjem dijelu tijela.", PrimaryCategoryId = 2 },
                new SecondaryCategory { SecondaryCategoryId = 5, Name = "Trbušni mišići", Description = "Poznati kao 6-pack, ovi mišići dolaze do izražaja kod manjeg postotka tijelesne masnoće.", PrimaryCategoryId = 2 }, 
                new SecondaryCategory { SecondaryCategoryId = 6, Name = "Biceps", Description = "Dvoglavi mišić.", PrimaryCategoryId = 2 }, 
                new SecondaryCategory { SecondaryCategoryId = 7, Name = "Triceps", Description = "Troglavi mišić - čini 60% muskulature i gornjem dijelu ruke.", PrimaryCategoryId = 2 }, 
                new SecondaryCategory { SecondaryCategoryId = 8, Name = "Podlaktica", Description = "", PrimaryCategoryId = 2 } ,
                new SecondaryCategory { SecondaryCategoryId = 9, Name = "Kvadriceps", Description = "Četveroglavi mišić na prednjem dijelu noge.", PrimaryCategoryId = 3 }, 
                new SecondaryCategory { SecondaryCategoryId = 10, Name = "Gluteus", Description = "Najveća mišićna skupina na tijelu", PrimaryCategoryId = 3 }, 
                new SecondaryCategory { SecondaryCategoryId = 11, Name = "Zadnja loža", Description = "Dvoglavi mišić na stražnjem dijelu noge.", PrimaryCategoryId = 3 },
                new SecondaryCategory { SecondaryCategoryId = 12, Name = "List", Description = "Mišić donjeg dijela noge.", PrimaryCategoryId = 3 },
                new SecondaryCategory { SecondaryCategoryId = 13, Name = "Cijelo tijelo", Description = "", PrimaryCategoryId = 1 },
                new SecondaryCategory { SecondaryCategoryId = 14, Name = "Kardio", Description = "", PrimaryCategoryId = 4 });

            modelBuilder.Entity<ExerciseCategoryRelationship>().HasData(
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 1, ExerciseId = 1, SecondaryCategoryId = 9 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 2, ExerciseId = 1, SecondaryCategoryId = 10 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 3, ExerciseId = 1, SecondaryCategoryId = 11 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 4, ExerciseId = 2, SecondaryCategoryId = 9 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 5, ExerciseId = 2, SecondaryCategoryId = 10 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 6, ExerciseId = 2, SecondaryCategoryId = 11 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 7, ExerciseId = 3, SecondaryCategoryId = 9 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 8, ExerciseId = 3, SecondaryCategoryId = 10 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 9, ExerciseId = 3, SecondaryCategoryId = 11 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 10, ExerciseId = 4, SecondaryCategoryId = 4 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 12, ExerciseId = 4, SecondaryCategoryId = 6 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 13, ExerciseId = 5, SecondaryCategoryId = 4 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 14, ExerciseId = 5, SecondaryCategoryId = 6 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 15, ExerciseId = 6, SecondaryCategoryId = 4 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 16, ExerciseId = 6, SecondaryCategoryId = 6 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 17, ExerciseId = 7, SecondaryCategoryId = 9 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 18, ExerciseId = 7, SecondaryCategoryId = 10 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 19, ExerciseId = 7, SecondaryCategoryId = 11 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 20, ExerciseId = 7, SecondaryCategoryId = 4 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 21, ExerciseId = 7, SecondaryCategoryId = 13 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 22, ExerciseId = 8, SecondaryCategoryId = 9 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 23, ExerciseId = 8, SecondaryCategoryId = 10 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 24, ExerciseId = 8, SecondaryCategoryId = 11 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 25, ExerciseId = 8, SecondaryCategoryId = 4 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 26, ExerciseId = 8, SecondaryCategoryId = 13 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 27, ExerciseId = 9, SecondaryCategoryId = 4 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 28, ExerciseId = 9, SecondaryCategoryId = 9 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 29, ExerciseId = 9, SecondaryCategoryId = 10 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 30, ExerciseId = 9, SecondaryCategoryId = 11 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 31, ExerciseId = 9, SecondaryCategoryId = 13 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 32, ExerciseId = 10, SecondaryCategoryId = 7 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 33, ExerciseId = 11, SecondaryCategoryId = 7 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 34, ExerciseId = 12, SecondaryCategoryId = 7 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 35, ExerciseId = 12, SecondaryCategoryId = 2 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 36, ExerciseId = 12, SecondaryCategoryId = 3 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 37, ExerciseId = 13, SecondaryCategoryId = 6 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 38, ExerciseId = 14, SecondaryCategoryId = 6 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 39, ExerciseId = 15, SecondaryCategoryId = 6 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 40, ExerciseId = 15, SecondaryCategoryId = 8 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 41, ExerciseId = 16, SecondaryCategoryId = 2 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 42, ExerciseId = 16, SecondaryCategoryId = 4 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 43, ExerciseId = 19, SecondaryCategoryId = 2 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 44, ExerciseId = 17, SecondaryCategoryId = 2 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 45, ExerciseId = 17, SecondaryCategoryId = 7 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 46, ExerciseId = 18, SecondaryCategoryId = 2 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 47, ExerciseId = 18, SecondaryCategoryId = 7 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 48, ExerciseId = 20, SecondaryCategoryId = 2 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 49, ExerciseId = 20, SecondaryCategoryId = 3 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 50, ExerciseId = 20, SecondaryCategoryId = 7 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 51, ExerciseId = 21, SecondaryCategoryId = 2 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 52, ExerciseId = 21, SecondaryCategoryId = 3 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 53, ExerciseId = 21, SecondaryCategoryId = 7 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 54, ExerciseId = 22, SecondaryCategoryId = 3 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 55, ExerciseId = 23, SecondaryCategoryId = 5 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 56, ExerciseId = 24, SecondaryCategoryId = 5 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 57, ExerciseId = 25, SecondaryCategoryId = 5 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 58, ExerciseId = 30, SecondaryCategoryId = 1 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 59, ExerciseId = 31, SecondaryCategoryId = 1 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 60, ExerciseId = 32, SecondaryCategoryId = 8 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 61, ExerciseId = 33, SecondaryCategoryId = 8 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 62, ExerciseId = 34, SecondaryCategoryId = 8 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 63, ExerciseId = 35, SecondaryCategoryId = 8 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 64, ExerciseId = 36, SecondaryCategoryId = 12 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 65, ExerciseId = 37, SecondaryCategoryId = 12 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 66, ExerciseId = 38, SecondaryCategoryId = 12 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 67, ExerciseId = 39, SecondaryCategoryId = 4 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 68, ExerciseId = 39, SecondaryCategoryId = 8 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 69, ExerciseId = 39, SecondaryCategoryId = 9 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 70, ExerciseId = 39, SecondaryCategoryId = 10 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 71, ExerciseId = 39, SecondaryCategoryId = 11 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 72, ExerciseId = 39, SecondaryCategoryId = 13 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 73, ExerciseId = 40, SecondaryCategoryId = 2 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 74, ExerciseId = 40, SecondaryCategoryId = 4 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 75, ExerciseId = 40, SecondaryCategoryId = 7 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 76, ExerciseId = 40, SecondaryCategoryId = 9 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 77, ExerciseId = 40, SecondaryCategoryId = 10 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 78, ExerciseId = 40, SecondaryCategoryId = 11 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 79, ExerciseId = 40, SecondaryCategoryId = 13 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 80, ExerciseId = 41, SecondaryCategoryId = 4 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 81, ExerciseId = 41, SecondaryCategoryId = 9 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 82, ExerciseId = 41, SecondaryCategoryId = 10 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 83, ExerciseId = 41, SecondaryCategoryId = 11 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 84, ExerciseId = 41, SecondaryCategoryId = 13 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 85, ExerciseId = 41, SecondaryCategoryId = 12 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 86, ExerciseId = 39, SecondaryCategoryId = 12 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 87, ExerciseId = 42, SecondaryCategoryId = 2 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 88, ExerciseId = 42, SecondaryCategoryId = 4 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 89, ExerciseId = 42, SecondaryCategoryId = 7 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 90, ExerciseId = 42, SecondaryCategoryId = 9 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 91, ExerciseId = 42, SecondaryCategoryId = 10 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 92, ExerciseId = 42, SecondaryCategoryId = 11 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 93, ExerciseId = 42, SecondaryCategoryId = 13 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 94, ExerciseId = 43, SecondaryCategoryId = 2 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 95, ExerciseId = 43, SecondaryCategoryId = 4 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 96, ExerciseId = 43, SecondaryCategoryId = 7 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 97, ExerciseId = 43, SecondaryCategoryId = 9 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 98, ExerciseId = 43, SecondaryCategoryId = 10 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 99, ExerciseId = 43, SecondaryCategoryId = 11 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 100, ExerciseId = 43, SecondaryCategoryId = 13 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 101, ExerciseId = 44, SecondaryCategoryId = 14 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 102, ExerciseId = 45, SecondaryCategoryId = 14 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 103, ExerciseId = 46, SecondaryCategoryId = 14 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 104, ExerciseId = 47, SecondaryCategoryId = 14 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 105, ExerciseId = 48, SecondaryCategoryId = 14 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 106, ExerciseId = 49, SecondaryCategoryId = 2 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 107, ExerciseId = 49, SecondaryCategoryId = 4 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 108, ExerciseId = 49, SecondaryCategoryId = 7 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 109, ExerciseId = 49, SecondaryCategoryId = 9 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 110, ExerciseId = 49, SecondaryCategoryId = 10 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 111, ExerciseId = 49, SecondaryCategoryId = 11 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 112, ExerciseId = 49, SecondaryCategoryId = 13 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 113, ExerciseId = 50, SecondaryCategoryId = 2 },
                //new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 114, ExerciseId = 50, SecondaryCategoryId = 4 },
                new ExerciseCategoryRelationship { ExerciseCategoryRelationshipId = 115, ExerciseId = 50, SecondaryCategoryId = 7 }
                );

            

            modelBuilder.Entity<ExerciseTag>().HasData(
               new ExerciseTag { ExerciseTagId = 1, Name = "Vrat" }, 
               new ExerciseTag { ExerciseTagId = 2, Name = "Prsa" },
               new ExerciseTag { ExerciseTagId = 3, Name = "Ramena" }, 
               new ExerciseTag { ExerciseTagId = 4, Name = "Leđa" }, 
               new ExerciseTag { ExerciseTagId = 5, Name = "Trbušni mišići" }, 
               new ExerciseTag { ExerciseTagId = 6, Name = "Biceps" }, 
               new ExerciseTag { ExerciseTagId = 7, Name = "Triceps" }, 
               new ExerciseTag { ExerciseTagId = 8, Name = "Kvadriceps" }, 
               new ExerciseTag { ExerciseTagId = 9, Name = "Zadnja loža" }, 
               new ExerciseTag { ExerciseTagId = 10, Name = "Gluteus" }, 
               new ExerciseTag { ExerciseTagId = 11, Name = "List" }, 
               new ExerciseTag { ExerciseTagId = 12, Name = "Podlaktica" }
               );

            modelBuilder.Entity<PrimaryExerciseTagRelationship>().HasData(
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 1, ExerciseId = 1, TagId = 8 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 2, ExerciseId = 1, TagId = 10 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 3, ExerciseId = 2, TagId = 8 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 4, ExerciseId = 2, TagId = 10 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 5, ExerciseId = 3, TagId = 10 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 6, ExerciseId = 3, TagId = 8 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 7, ExerciseId = 3, TagId = 9 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 8, ExerciseId = 4, TagId = 4 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 9, ExerciseId = 5, TagId = 4 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 10, ExerciseId = 6, TagId = 4 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 11, ExerciseId = 7, TagId = 9 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 12, ExerciseId = 7, TagId = 10 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 13, ExerciseId = 7, TagId = 8 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 14, ExerciseId = 8, TagId = 8 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 15, ExerciseId = 8, TagId = 10 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 16, ExerciseId = 8, TagId = 9 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 17, ExerciseId = 9, TagId = 9 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 18, ExerciseId = 9, TagId = 10 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 19, ExerciseId = 9, TagId = 4 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 20, ExerciseId = 10, TagId = 7 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 21, ExerciseId = 11, TagId = 7 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 22, ExerciseId = 12, TagId = 7 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 23, ExerciseId = 12, TagId = 2 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 24, ExerciseId = 12, TagId = 3 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 25, ExerciseId = 13, TagId = 6 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 26, ExerciseId = 14, TagId = 6 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 27, ExerciseId = 15, TagId = 6 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 28, ExerciseId = 15, TagId = 12 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 29, ExerciseId = 16, TagId = 3 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 30, ExerciseId = 17, TagId = 3 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 31, ExerciseId = 18, TagId = 3 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 32, ExerciseId = 19, TagId = 3 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 33, ExerciseId = 20, TagId = 2 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 34, ExerciseId = 21, TagId = 2 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 35, ExerciseId = 21, TagId = 3 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 36, ExerciseId = 22, TagId = 2 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 37, ExerciseId = 23, TagId = 5 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 38, ExerciseId = 24, TagId = 5 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 39, ExerciseId = 25, TagId = 5 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 41, ExerciseId = 30, TagId = 1 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 42, ExerciseId = 31, TagId = 1 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 43, ExerciseId = 32, TagId = 12 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 44, ExerciseId = 33, TagId = 12 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 45, ExerciseId = 34, TagId = 12 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 46, ExerciseId = 35, TagId = 12 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 47, ExerciseId = 36, TagId = 11 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 48, ExerciseId = 37, TagId = 11 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 49, ExerciseId = 38, TagId = 11 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 50, ExerciseId = 39, TagId = 4 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 51, ExerciseId = 39, TagId = 8 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 52, ExerciseId = 39, TagId = 10 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 53, ExerciseId = 39, TagId = 12 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 54, ExerciseId = 39, TagId = 9 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 55, ExerciseId = 40, TagId = 3 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 56, ExerciseId = 40, TagId = 4 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 57, ExerciseId = 40, TagId = 10 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 58, ExerciseId = 40, TagId = 8 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 59, ExerciseId = 41, TagId = 4 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 60, ExerciseId = 41, TagId = 8 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 61, ExerciseId = 41, TagId = 10 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 62, ExerciseId = 41, TagId = 11 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 63, ExerciseId = 42, TagId = 3 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 64, ExerciseId = 42, TagId = 4 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 65, ExerciseId = 42, TagId = 10 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 66, ExerciseId = 42, TagId = 8 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 67, ExerciseId = 43, TagId = 3 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 68, ExerciseId = 43, TagId = 4 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 69, ExerciseId = 43, TagId = 10 },
                new PrimaryExerciseTagRelationship { PrimaryExerciseTagRelationshipId = 70, ExerciseId = 43, TagId = 8 }
                );
            modelBuilder.Entity<SecondaryExerciseTagRelationship>().HasData(
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 1, ExerciseId = 1, TagId = 4 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 2, ExerciseId = 1, TagId = 9 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 3, ExerciseId = 1, TagId = 5 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 4, ExerciseId = 2, TagId = 4 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 5, ExerciseId = 2, TagId = 9 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 6, ExerciseId = 2, TagId = 5 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 7, ExerciseId = 3, TagId = 11 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 8, ExerciseId = 3, TagId = 4 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 9, ExerciseId = 4, TagId = 6 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 10, ExerciseId = 5, TagId = 6 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 11, ExerciseId = 6, TagId = 6 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 12, ExerciseId = 7, TagId = 4 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 13, ExerciseId = 7, TagId = 5 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 14, ExerciseId = 7, TagId = 12 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 15, ExerciseId = 8, TagId = 4 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 16, ExerciseId = 8, TagId = 5 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 17, ExerciseId = 8, TagId = 12 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 18, ExerciseId = 9, TagId = 5 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 19, ExerciseId = 9, TagId = 12 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 20, ExerciseId = 13, TagId = 12 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 21, ExerciseId = 14, TagId = 12 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 22, ExerciseId = 16, TagId = 4 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 23, ExerciseId = 16, TagId = 6 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 24, ExerciseId = 17, TagId = 2 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 25, ExerciseId = 17, TagId = 7 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 26, ExerciseId = 18, TagId = 7 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 27, ExerciseId = 20, TagId = 3 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 28, ExerciseId = 20, TagId = 7 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 29, ExerciseId = 21, TagId = 7 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 30, ExerciseId = 39, TagId = 5 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 31, ExerciseId = 39, TagId = 11 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 32, ExerciseId = 40, TagId = 2 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 33, ExerciseId = 40, TagId = 5 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 34, ExerciseId = 40, TagId = 6 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 35, ExerciseId = 40, TagId = 7 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 36, ExerciseId = 41, TagId = 5 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 37, ExerciseId = 41, TagId = 9 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 38, ExerciseId = 42, TagId = 5 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 39, ExerciseId = 42, TagId = 6 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 40, ExerciseId = 42, TagId = 7 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 41, ExerciseId = 43, TagId = 5 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 42, ExerciseId = 43, TagId = 6 },
                new SecondaryExerciseTagRelationship { SecondaryExerciseTagRelationshipId = 43, ExerciseId = 43, TagId = 7 }
                );



            /*modelBuilder.Entity<SecondaryTertiaryRelationship>().HasData(
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 1, SecondaryCategoryId = 2, TertiaryCategoryId = 7 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 2, SecondaryCategoryId = 2, TertiaryCategoryId = 8 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 3, SecondaryCategoryId = 2, TertiaryCategoryId = 9 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 4, SecondaryCategoryId = 3, TertiaryCategoryId = 1 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 5, SecondaryCategoryId = 3, TertiaryCategoryId = 2 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 6, SecondaryCategoryId = 4, TertiaryCategoryId = 3 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 7, SecondaryCategoryId = 4, TertiaryCategoryId = 4 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 8, SecondaryCategoryId = 4, TertiaryCategoryId = 5 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 9, SecondaryCategoryId = 4, TertiaryCategoryId = 6 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 10, SecondaryCategoryId = 6, TertiaryCategoryId = 14 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 11, SecondaryCategoryId = 6, TertiaryCategoryId = 13 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 12, SecondaryCategoryId = 7, TertiaryCategoryId = 10 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 13, SecondaryCategoryId = 7, TertiaryCategoryId = 11 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 14, SecondaryCategoryId = 7, TertiaryCategoryId = 12 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 15, SecondaryCategoryId = 8, TertiaryCategoryId = 15 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 16, SecondaryCategoryId = 9, TertiaryCategoryId = 19 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 17, SecondaryCategoryId = 9, TertiaryCategoryId = 20 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 18, SecondaryCategoryId = 9, TertiaryCategoryId = 21 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 19, SecondaryCategoryId = 9, TertiaryCategoryId = 22 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 20, SecondaryCategoryId = 10, TertiaryCategoryId = 16 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 21, SecondaryCategoryId = 10, TertiaryCategoryId = 17 },
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 22, SecondaryCategoryId = 10, TertiaryCategoryId = 18 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 23, SecondaryCategoryId = 11, TertiaryCategoryId = 23 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 24, SecondaryCategoryId = 11, TertiaryCategoryId = 24 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 25, SecondaryCategoryId = 11, TertiaryCategoryId = 25 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 26, SecondaryCategoryId = 12, TertiaryCategoryId = 26 }, 
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 27, SecondaryCategoryId = 12, TertiaryCategoryId = 27 },
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 28, SecondaryCategoryId = 2, TertiaryCategoryId = 28 },
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 29, SecondaryCategoryId = 5, TertiaryCategoryId = 29 },
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 30, SecondaryCategoryId = 5, TertiaryCategoryId = 30 },
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 31, SecondaryCategoryId = 5, TertiaryCategoryId = 31 },
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 32, SecondaryCategoryId = 8, TertiaryCategoryId = 32 },
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 33, SecondaryCategoryId = 8, TertiaryCategoryId = 33 },
                new SecondaryTertiaryRelationship { SecondaryTertiaryRelationshipId = 34, SecondaryCategoryId = 1, TertiaryCategoryId = 34 });*/

            

            
           
        }
    }
}
