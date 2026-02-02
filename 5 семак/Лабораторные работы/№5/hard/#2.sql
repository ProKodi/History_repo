



USE student;


/* SELECT * FROM exams */

/* SELECT id, name FROM disciplines */

/* SELECT id_student, date, mark, discp.name FROM exams
  INNER JOIN(
    SELECT id, name FROM disciplines
  ) AS discp
  ON exams.id_discipline = discp.id

*/

USE student;

/* Проблема: Она хочет групировку по предметам (как фильтрация типо),
  но если мы это сделаем то мы сможем заюзать только агрегатные функции (не получится сделать список студентов)
*/
SELECT students.name, `group`, date, mark, exam_discp.name  FROM students
  INNER JOIN(
    SELECT id_student, date, mark, disciplines.name FROM exams
    INNER JOIN disciplines
    ON exams.id_discipline = disciplines.id

    WHERE mark >= 3  -- AND disciplines.name = "Базы данных"
  ) AS exam_discp
  ON students.id = exam_discp.id_student
  order by exam_discp.name -- maybe it? 
  
  LIMIT 0, 1000

;

;