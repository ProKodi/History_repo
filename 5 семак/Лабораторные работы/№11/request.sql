


USE student;

/* ------ 1 ------ */
SELECT * FROM students s 
  WHERE NOT EXISTS(
    SELECT * FROM exams e
      WHERE e.id_student = s.id && e.mark = 3
  );

/* ------ 2 ------ */
SELECT * FROM students s 
  WHERE NOT EXISTS(
    SELECT * FROM exams e
      WHERE e.id_student = s.id && e.mark IN (4, 5)
  );

/* ------ 3 ------ */
set @IdDB = (
  SELECT id FROM disciplines d
    WHERE name = "Базы данных"
);

select * FROM students s
  WHERE not EXISTS(
    select * FROM exams e
      WHERE e.id_student = s.id AND e.id_discipline = @IdDB
  )

/* ------ 5 ------ */
select * FROM students s
  WHERE EXISTS(
    SELECT * FROM exams e
      WHERE e.id_discipline = @IdDB AND e.mark = 4
  ) AND EXISTS(
    SELECT * FROM exams e
      WHERE e.id_discipline != @IdDB AND e.mark = 5
  )

/* ------ 4 ------ */
select * FROM students s
  WHERE (
    SELECT COUNT(*) FROM exams e
      WHERE e.id_student = s.id
  ) > 1

/* ------ 6 ------ */
set @CountDisp = (SELECT count(DISTINCT id) FROM disciplines);

SELECT * FROM students s
  WHERE (
    SELECT COUNT(DISTINCT e.id_discipline) FROM exams e
      WHERE e.id_student = s.id
  ) = @CountDisp

/* ------ 7 ------ */
set @IdOS = (
  SELECT id FROM disciplines d
    WHERE d.name = "Операционные системы"
);

SELECT * FROM students s0
  JOIN exams e0
  ON s0.id = e0.id_student

  WHERE (
    SELECT avg(e.mark) from students s
      JOIN exams e 
      ON s.id = e.id_student
      
      WHERE e.id_discipline = @IdOS AND s.`group` = s0.`group`
      GROUP BY s.`group`
  ) < e0.mark