using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string c = department?.ToUpper(); // Use null-conditional operator to avoid null reference exception
        
        if (id == null && department == null)
        {
            return name + " - OWNER"; // Print only name for owner
        }
        else if (id != null && department == null)
        {
            return $"[{id}] - {name} - OWNER"; // Print ID along with name for owner
        }
        else if (id == null && department != null)
        {
            return $"{name} - {c}"; // Print name and department
        }
        else
        {
            return $"[{id}] - {name} - {c}"; // Print ID, name, and department
        }
    }
}
