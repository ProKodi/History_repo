



USE student;

SELECT * FROM students
  WHERE YEAR(birthday) < 2001
  LIMIT 0, 1000

;