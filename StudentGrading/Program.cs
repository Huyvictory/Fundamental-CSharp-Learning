using System;

// initialize variables - graded assignments
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaAssignentScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };

int[] andrewAssignmentScores = new int[] { 92, 89, 81, 96, 90, 89 };

int[] emmaAssignmentScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };

int[] loganAssignmentScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string showGradeLetter(decimal grade)
{
    if (grade >= 97m)
        return "A+";
    else if (grade >= 93m)
        return "A";
    else if (grade >= 90m)
        return "A-";
    else if (grade >= 87m)
        return "B+";
    else if (grade >= 83m)
        return "B";
    else if (grade >= 80m)
        return "B-";
    else if (grade >= 77m)
        return "C+";
    else if (grade >= 73m)
        return "C";
    else if (grade >= 70m)
        return "C-";
    else if (grade >= 67m)
        return "D+";
    else if (grade >= 63m)
        return "D";
    else if (grade >= 60m)
        return "D-";
    else
        return "F";
}

Console.WriteLine("Student\t\tExamScore\tOverall\tLetter Grade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaAssignentScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewAssignmentScores;
    else if (currentStudent == "Emma")
        studentScores = emmaAssignmentScores;
    else if (currentStudent == "Logan")
        studentScores = loganAssignmentScores;

    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    decimal extraCredits = 0;
    decimal examScore = 0;

    // initialize/reset a counter for the number of assignment
    int gradedAssignments = 0;

    // loop through the scores array and complete calculations for currentStudent
    foreach (int score in studentScores)
    {
        // increment the assignment counter
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
        // add the exam score to the sum
        {
            sumAssignmentScores += score;
            examScore += score;
        }
        else
        // add the extra credit points to the sum - bonus points equal to 10% of an exam score
        {
            extraCredits += score;
        }
    }

    currentStudentGrade = (sumAssignmentScores + (extraCredits / 10)) / examAssignments;
    examScore = examScore / examAssignments;
    extraCredits = extraCredits / 10 / examAssignments;

    Console.WriteLine(
        $"{currentStudent}\t\t{examScore}\t\t{currentStudentGrade}\t{showGradeLetter(currentStudentGrade)}\t\t({extraCredits} pts)"
    );
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
