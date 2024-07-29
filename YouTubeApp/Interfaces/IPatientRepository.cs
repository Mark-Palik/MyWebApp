﻿using YouTubeApp.Models;

namespace YouTubeApp.Interfaces
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> GetAllPatients();
        public void SaveChanges();
        public void CreatePatient(Patient patient);
        public Patient GetPatientById(int? id);

    }
}
