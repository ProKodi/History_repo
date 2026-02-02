



USE student;


/*
SELECT id_student FROM exams
*/

/*
SELECT * FROM students 
*/

SELECT * FROM students 
  LEFT JOIN exams 
  ON exams.id_student = students.id
  WHERE exams.id_student IS NULL
  LIMIT 0, 1000

;