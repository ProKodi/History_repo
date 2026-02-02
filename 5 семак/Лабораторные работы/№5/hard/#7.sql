



USE student;


/*
SELECT students.name, `group`, date, mark, exam_discp.name  FROM students
    INNER JOIN(
        SELECT id_student, date, mark, discp.name FROM exams
        INNER JOIN(
            SELECT id, name FROM disciplines
        ) AS discp
        ON exams.id_discipline = discp.id
    ) AS exam_discp
    ON students.id = exam_discp.id_student
    
*/


-- SELECT * FROM exams

-- SELECT * FROM disciplines

SELECT students.name AS name_student, disciplines.name AS discipline_name, date, mark  FROM exams
  INNER JOIN disciplines 
  ON disciplines.id = exams.id_discipline

  INNER JOIN students
  ON students.id = exams.id_student
  
  LIMIT 0, 1000
;