



USE student;

/* SELECT * FROM specialties */

/* SELECT id_specialty FROM students   */

SELECT * FROM specialties
  LEFT JOIN (
    SELECT id_specialty FROM students
      WHERE students.nuber_course = 5
  ) as sl_st
  ON sl_st.id_specialty = specialties.id

  WHERE sl_st.id_specialty IS NULL
  LIMIT 0, 1000

;