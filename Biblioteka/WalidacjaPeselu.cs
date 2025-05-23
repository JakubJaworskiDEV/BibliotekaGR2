﻿using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class PeselValidator
{
    private DataTable usersTable;
    private string currentLogin;

    public PeselValidator(DataTable usersTable, string currentLogin)
    {
        this.usersTable = usersTable;
        this.currentLogin = currentLogin;
    }

    public bool ValidatePesel(string pesel)
    {
        if (!Regex.IsMatch(pesel, "^\\d{11}$"))
        {
            MessageBox.Show("Niepoprawny numer PESEL", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (usersTable != null && usersTable.AsEnumerable().Any(row => 
            row["PESEL"].ToString() == pesel && 
            row["Login"].ToString() != currentLogin))
        {
            MessageBox.Show("Niepoprawny numer PESEL", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        string birthDate = pesel.Substring(0, 6);
        if (!IsValidBirthDate(birthDate))
        {
            MessageBox.Show("Niepoprawny numer PESEL", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        string gender = (int.Parse(pesel[9].ToString()) % 2 == 0) ? "Kobieta" : "Mężczyzna";

        if (!IsValidControlDigit(pesel))
        {
            MessageBox.Show("Niepoprawny numer PESEL", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    private bool IsValidBirthDate(string birthDate)
    {
        try
        {
            int year = int.Parse(birthDate.Substring(0, 2));
            int month = int.Parse(birthDate.Substring(2, 2));
            int day = int.Parse(birthDate.Substring(4, 2));

            int fullYear = GetFullYear(year, month);
            month = AdjustMonth(month);

            DateTime date = new DateTime(fullYear, month, day);
            return true;
        }
        catch
        {
            return false;
        }
    }

    private int GetFullYear(int year, int month)
    {
        if (month > 80) return 1800 + year;
        if (month > 60) return 2200 + year;
        if (month > 40) return 2100 + year;
        if (month > 20) return 2000 + year;
        return 1900 + year;
    }

    private int AdjustMonth(int month)
    {
        if (month > 80) return month - 80;
        if (month > 60) return month - 60;
        if (month > 40) return month - 40;
        if (month > 20) return month - 20;
        return month;
    }

    private bool IsValidControlDigit(string pesel)
    {
        int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        int sum = 0;

        for (int i = 0; i < 10; i++)
        {
            sum += (pesel[i] - '0') * weights[i];
        }

        int controlDigit = (10 - (sum % 10)) % 10;
        return controlDigit == (pesel[10] - '0');
    }
}