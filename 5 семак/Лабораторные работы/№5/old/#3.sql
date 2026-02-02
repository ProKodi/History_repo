



USE student;


SELECT * FROM students
  WHERE TIMESTAMPDIFF(YEAR, birthday, CURRENT_DATE()) = 18
  LIMIT 0, 1000
;