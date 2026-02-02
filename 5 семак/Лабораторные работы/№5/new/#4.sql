



USE student;

select sex, COUNT(*) FROM students
  GROUP BY sex;
;