



USE student;

/* Что это вообще такое? */

/* ----- 1 ----- */
SELECT nuber_course, COUNT(*) AS cnt FROM students
  GROUP BY nuber_course
  HAVING cnt > 1

/* ----- 2 ----- */
SELECT sex, AVG(YEAR(NOW()) - YEAR(birthday)) AS AvgBith FROM students
  GROUP BY sex
  HAVING AvgBith < 100

/* ----- 3 ----- */
SELECT nuber_course, MAX(YEAR(birthday)) AS MaxYear FROM students
  GROUP BY nuber_course
  HAVING MaxYear > 2000

/* ----- 4 ----- */
SELECT `group`  FROM students as MainSt
  GROUP BY `group`
  HAVING EXISTS (
    SELECT * FROM students stt
      WHERE stt.sex = "Мужской"  AND stt.`group` = MainSt.`group`
  ) AND EXISTS(
    SELECT * FROM students stt
      WHERE stt.sex = "Женский"  AND stt.`group` = MainSt.`group`
  )


/* ----- 5 ----- */
SELECT nuber_course, SUM(CHARACTER_LENGTH(TRIM(name))) AS SumLengh FROM students
  GROUP BY nuber_course
  HAVING SumLengh > 10

/* ----- 6 ----- */
SELECT sex, MIN(nuber_course) AS MinCour  FROM students
  GROUP BY sex
  HAVING MinCour = 1

/* ----- 7 ----- */
SELECT DISTINCT  nuber_course  FROM students
  HAVING nuber_course BETWEEN 1 AND 5

/* ----- 8 ----- */
SELECT `group`, COUNT(*) AS CNT  FROM students
  GROUP BY `group`
  HAVING CNT BETWEEN 0 AND 15

/* ----- 9 ----- */
SELECT sex, MIN(nuber_course) AS MinCour, MAX(nuber_course) AS MaxCour  FROM students
  GROUP BY sex
  HAVING (MaxCour - MinCour) > 2

/* ----- 10 ----- */
SELECT nuber_course, COUNT(*) AS CNT, Max(CHARACTER_LENGTH(name)) AS LengName FROM students
  GROUP BY nuber_course
  HAVING CNT > 1 AND LengName > 14