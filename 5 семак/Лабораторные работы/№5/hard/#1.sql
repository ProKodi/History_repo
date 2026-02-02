



USE student;


/* SELECT DISTINCT id, name FROM Specialties  */

SELECT students.name, specialties.name FROM students
  INNER JOIN specialties
  ON students.id_specialty = specialties.id

  LIMIT 0, 1000


;