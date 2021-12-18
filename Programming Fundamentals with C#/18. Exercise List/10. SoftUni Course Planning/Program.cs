using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();  
            string command = Console.ReadLine();

          
            while (command != "course start")
            {
                string[] curentCommand = command.Split(":").ToArray();
                string action = curentCommand[0];
                string lessonTitle = curentCommand[1];
                string exerciseAction = (lessonTitle + "-Exercise");



                if (action == "Add")
                {
                    bool IsThereLesson = Check(lessons, lessonTitle);
                    if (!IsThereLesson)
                    {
                        lessons.Add(lessonTitle);
                    }
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(curentCommand[2]);
                    if (index >= 0 || index < lessons.Count)
                    {

                        bool IsThereLesson = Check(lessons, lessonTitle);
                        if (!IsThereLesson)
                        {
                            lessons.Insert(index, lessonTitle);
                        }
                    }
                }
                else if (action == "Remove")
                {
                    bool IsThereLesson = Check(lessons, lessonTitle);
                    bool IsThereLessonExercises = Check(lessons, exerciseAction);
                    if (IsThereLesson && IsThereLessonExercises)
                    {
                        lessons.Remove(lessonTitle);
                        lessons.Remove(exerciseAction);
                    }
                    else
                    {
                        lessons.Remove(lessonTitle);
                    }
                }
                else if (action == "Swap")
                {
                    string swappedLessonTitle = curentCommand[2];
                    string swappedExercise = (swappedLessonTitle + "-Exercise");
                    bool IsThereFirstLesson = Check(lessons, lessonTitle);
                    bool IsThereSecondLesson = Check(lessons, swappedLessonTitle);
                    bool IsThereLessonExercises = Check(lessons, exerciseAction);
                    bool IsThereSwappedLessonExercises = Check(lessons, swappedExercise);

                    if (IsThereFirstLesson && IsThereSecondLesson)
                    {
                        Swap(lessons, lessonTitle, swappedLessonTitle);
                        if (IsThereLessonExercises && IsThereSwappedLessonExercises)
                        {
                            Swap(lessons, exerciseAction, swappedExercise);
                        }
                        else if (IsThereLessonExercises && !IsThereSwappedLessonExercises)
                        {
                            lessons.Remove(exerciseAction);
                            int index = GetIndex(lessons, lessonTitle);
                            lessons.Insert(index + 1, exerciseAction);
                        }
                        else if (!IsThereLessonExercises && IsThereSwappedLessonExercises)
                        {
                            lessons.Remove(swappedExercise);
                            int index = GetIndex(lessons, swappedLessonTitle);
                            lessons.Insert(index + 1, swappedExercise);
                        }
                    }
                }
                else if (action == "Exercise")
                {
                    bool IsThereLesson = Check(lessons, lessonTitle);
                    bool IsThereLessonExercises = Check(lessons, exerciseAction);

                    if (IsThereLesson && !IsThereLessonExercises)
                    {

                        int index = GetIndex(lessons, lessonTitle);
                        lessons.Insert(index + 1, exerciseAction);
                    }
                    else if (!IsThereLesson)
                    {
                        lessons.Add(lessonTitle);
                        lessons.Add(exerciseAction);
                    }
                }

                command = Console.ReadLine();

            }
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }

        static int GetIndex(List<string> lessons, string lessonTitle)
        {
            int index = -1;
            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessons[i] == lessonTitle)
                {
                    index = i;
                }
            }
            return index;
        }

        static void Swap(List<string> lessons, string lessonTitle, string swappedLessonTitle)
        {
            int first = int.MinValue;
            int second = int.MinValue;

            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessons[i] == lessonTitle)
                {
                    first = i;
                }
                if (lessons[i] == swappedLessonTitle)
                {
                    second = i;
                }
            }
            lessons[first] = swappedLessonTitle;
            lessons[second] = lessonTitle;
        }

        static bool Check(List<string> lessons, string lessonTitle)
        {
            bool IsThere = false;

            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessons[i] == lessonTitle)
                {
                    IsThere = true;
                }
            }
            if (!IsThere)
            {
                return IsThere;
            }
            else
            {
                return IsThere;
            }
        }
    }
}
