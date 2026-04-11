using System;

/* CREATIVITY AND EXCEEDING REQUIREMENTS:
   1. I Added a 'Negative Goal' class to track bad habits. This required 
      overriding the base class logic to deduct points instead of adding 
      them in the RecordEvent method.
   2. I Implemented a dynamic Leveling and Ranking system. The player's 
      rank (Novice to Legendary Hero) and Level update automatically in 
      the UI based on their total score.
   3. I Enhanced the User Experience by using ConsoleColors (Cyan for levels, 
      Green for rewards, and Red for penalties) to make the gamification 
      more engaging and professional.
*/

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}