Console.WriteLine("Банковский счет");

double balance = 1000;
Console.WriteLine($"Starting balance: {balance}");

balance += 500; // ++
Console.WriteLine($"Popolnenie na 500: {balance}");

balance -= 200; // buy
Console.WriteLine($"after buying: {balance}");

balance *= 1.05; // + 5%
Console.WriteLine($"+ 5%: {balance}");

balance /= 2; // партнер украл половину
Console.WriteLine($"после кражи: {balance}");

Console.WriteLine();
Console.WriteLine("постфикс vs префикс");

int lessonNumber = 1;
Console.WriteLine($"lessonNumber++: {lessonNumber++}");
Console.WriteLine($"after: {lessonNumber}");

int weekNumber = 1;
Console.WriteLine($"++weekNumber: {++weekNumber}");
Console.WriteLine($"after: {weekNumber}");

Console.WriteLine();
Console.WriteLine("lovushka");

int attempts = 0;
Console.WriteLine($"attempt №{++attempts}");
Console.WriteLine($"attempt №{++attempts}");
Console.WriteLine($"Attempts: {attempts}");

Console.WriteLine();
Console.WriteLine("sravnenie");

double myGrade = 4.6;
double passingGrade = 4.0;
int myAge = 20;
int votingAge = 18;
bool isPassing = myGrade >= passingGrade;
bool isExactAge = myAge == votingAge;
bool canVote = myAge >= votingAge;
bool isNotFailing = myGrade != 2.0;

Console.WriteLine($"ball {myGrade} >= {passingGrade}: {isPassing}");
Console.WriteLine($"age {myAge} == {votingAge}: {isExactAge}");
Console.WriteLine($"age {myAge} >= {votingAge} (can voite): {canVote}");
Console.WriteLine($"ball {myGrade} != 2.0: {isNotFailing}");

Console.WriteLine();
Console.WriteLine("logic operators (ne sturm!)");

bool hasPassingGrade = true;
bool hasAttendance = false;
bool hasDebt = true;

bool canGetScholarship = hasPassingGrade && hasAttendance;
bool canRetakeExam = hasPassingGrade || hasAttendance;
bool isDebtFree = !hasDebt;

Console.WriteLine($"Can get stependiu (оценка и посещаемость): {canGetScholarship}");
Console.WriteLine($"Can retake exam (оценка или посещаемость): {canRetakeExam}");
Console.WriteLine($"no dolgov: {isDebtFree}");

Console.WriteLine();
Console.WriteLine("KZ");

bool CheckAndPrint(string label, bool value)
{
    Console.WriteLine($"    вычисляется: {label}");
    return value;
}

Console.WriteLine("&& (1 false):");
bool resultAnd = CheckAndPrint("A", false) && CheckAndPrint("B", true);
Console.WriteLine($"result: {resultAnd}");

Console.WriteLine();
Console.WriteLine("check || (1: true)");
bool resultOr = CheckAndPrint("C", true) || CheckAndPrint("D", false);
Console.WriteLine($"result: {resultOr}");

Console.WriteLine();
Console.WriteLine("prioritet");

int resultNoParens = 2 + 3 * 4;
int resultWithParens = (2 + 3) * 4;
Console.WriteLine($"2 + 3 * 4 = {resultNoParens}");
Console.WriteLine($"(2 + 3) * 4 = {resultWithParens}");
bool logicResult = 5 > 3 && 2 < 4 || false;
bool logicResultParens = (5 > 3 && 2 < 4) || false;
Console.WriteLine($"no parens: {logicResult}");
Console.WriteLine($"parens: {logicResultParens}");

Console.WriteLine();
Console.WriteLine("Priemnaya kommissia");

Console.Write("Enter sredniy ball attestata: ");
double averageGrade = double.Parse(Console.ReadLine());

Console.Write("Enter balli za ekzamen (0-100): ");
int examScore = int.Parse(Console.ReadLine());

Console.Write("Есть льгота? (1 - yes, 0 - no): ");
int benefitInput = int.Parse(Console.ReadLine());

bool hasBenefit = (benefitInput == 1);
bool hasGoodCert = averageGrade >= 4.0;
bool hasGoodExam = examScore >= 60;
bool isEligibleByRules = (hasGoodCert && hasGoodExam) || hasBenefit;
double totalScore = averageGrade * 10;
totalScore += examScore;

Console.WriteLine();
Console.WriteLine("result:");
Console.WriteLine($"good attest (>= 4.0): {hasGoodCert}");
Console.WriteLine($"good exam (>= 60): {hasGoodExam}");
Console.WriteLine($"lgota: {hasBenefit}");
Console.WriteLine($"проходит по правилам: {isEligibleByRules}");
Console.WriteLine($"itogovii ball: {totalScore}");

Console.WriteLine();
Console.Write("четное дай пж: ");
int chetnoe = int.Parse(Console.ReadLine());
bool isEven = chetnoe % 2 == 0;

Console.WriteLine($"chetnoe: {isEven}");