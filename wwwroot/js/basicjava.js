$("#submitButton").click(
    function ()
    {
    var assignscore = parseInt($("#assignments").val());
    var quizscore = parseInt($("#quizzes").val());
    var gpscore = parseInt($("#groupprojects").val());
    var examscore = parseInt($("#exams").val());
    var intexscore = parseInt($("#intex").val());
    var finalGrade;
    var letterGrade;

    if (assignscore > 100 || assignscore < 0 || quizscore > 100 || quizscore < 0 || gpscore > 100 || gpscore < 0 ||
        examscore > 100 || examscore < 0 || intexscore > 100 || intexscore < 0) {
        alert("You may only enter in values that are in between 0 and 100. Please check your answers and try again.")
    }
    else if (assignscore <= 100 && assignscore >= 0 && quizscore <= 100 && quizscore >= 0 && gpscore <= 100 && gpscore >= 0 &&
        examscore <= 100 && examscore >= 0 && intexscore <= 100 && intexscore >= 0) {

        finalGrade = Math.round((assignscore * .5) + (quizscore * .1) + (gpscore * .1) + (examscore * .2) + (intexscore * .1));

        if (finalGrade >= 94)
            letterGrade = "A";
        else if (finalGrade >= 90)
            letterGrade = "A-";
        else if (finalGrade >= 87)
            letterGrade = "B+";
        else if (finalGrade >= 84)
            letterGrade = "B";
        else if (finalGrade >= 80)
            letterGrade = "B-";
        else if (finalGrade >= 77)
            letterGrade = "C+";
        else if (finalGrade >= 74)
            letterGrade = "C";
        else if (finalGrade >= 70)
            letterGrade = "C-";
        else if (finalGrade >= 67)
            letterGrade = "D+";
        else if (finalGrade >= 64)
            letterGrade = "D";
        else if (finalGrade >= 60)
            letterGrade = "D-";
        else
            letterGrade = "E";

        alert("Final grade = " + finalGrade + "% with a letter grade of: " + letterGrade);
    }
    else {
        alert("Please enter in a valid value for all inputs.")
    }
});

