



/*

USE student;


SELECT id_student, AVG(mark) AS avg_mark  FROM exams
  GROUP BY id_student
;


*/
USE student;


SELECT name, groped_avg_mark.avg_mark  FROM students
  INNER JOIN (
    SELECT id_student, AVG(mark) AS avg_mark FROM exams
      GROUP BY id_student
  ) AS groped_avg_mark
  on groped_avg_mark.id_student = id

  LIMIT 0, 1000

;