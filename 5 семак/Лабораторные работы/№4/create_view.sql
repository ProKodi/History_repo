



/* Личные данные - personal_data  */


SELECT DISTINCT
  `students`.`name` AS `name`,
  `students`.`sex` AS `sex`,
  `students`.`address` AS `address`,
  `students`.`phone_number` AS `phone_number`,
  `students`.`passport_data` AS `passport_data`,
  `students`.`birthday` AS `birthday`
FROM `students`


/* Специальности студентов - без сегрегации */

CREATE 
	DEFINER = 'root'@'localhost'
VIEW student.specialtie_student
AS
	SELECT
	  `students`.`name` AS `name_students`,
	  `students`.`sex` AS `sex`,
	  `students`.`parents` AS `parents`,
	  `students`.`address` AS `Город`,
	  `students`.`phone_number` AS `phone_number`,
	  `students`.`passport_data` AS `passport_data`,
	  `students`.`group` AS `group`,
	  `students`.`nuber_course` AS `nuber_course`,
	  `students`.`number_record_book` AS `number_record_book`,
	  `students`.`is_full_time` AS `is_full_time`,
	  `students`.`date_receipt` AS `date_receipt`,
	  `students`.`birthday` AS `birthday`,
	  `specialties`.`name` AS `name_specialties`,
	  `specialties`.`describe` AS `describe`
	FROM (`students`
	  JOIN `specialties`
	    ON ((`students`.`id_specialty` = `specialties`.`id`)));


/* Специальности студентов - specialtie_student_mm */
CREATE 
	DEFINER = 'root'@'localhost'
VIEW student.specialtie_student_mm
AS
	SELECT
	  `specialtie_student`.`name_specialties` AS `name_specialties`,
	  `specialtie_student`.`name_students` AS `name_students`,
	  `specialtie_student`.`sex` AS `sex`,
	  `specialtie_student`.`parents` AS `parents`,
	  `specialtie_student`.`Город` AS `Город`,
	  `specialtie_student`.`phone_number` AS `phone_number`,
	  `specialtie_student`.`passport_data` AS `passport_data`,
	  `specialtie_student`.`group` AS `group`,
	  `specialtie_student`.`nuber_course` AS `nuber_course`,
	  `specialtie_student`.`number_record_book` AS `number_record_book`,
	  `specialtie_student`.`is_full_time` AS `is_full_time`,
	  `specialtie_student`.`date_receipt` AS `date_receipt`,
	  `specialtie_student`.`birthday` AS `birthday`,
	  `specialtie_student`.`describe` AS `describe`
	FROM `specialtie_student`
	WHERE (`specialtie_student`.`name_specialties` = 'ММ');



/* Студенты специальностей ММ, ПИ, БУ -  specialtie_student_mm_pi_by*/
CREATE 
	DEFINER = 'root'@'localhost'
VIEW student.specialtie_student_mm_pi_by
AS
	SELECT
	  `specialtie_student`.`name_specialties` AS `name_specialties`,
	  `specialtie_student`.`name_students` AS `name_students`,
	  `specialtie_student`.`sex` AS `sex`,
	  `specialtie_student`.`parents` AS `parents`,
	  `specialtie_student`.`Город` AS `Город`,
	  `specialtie_student`.`phone_number` AS `phone_number`,
	  `specialtie_student`.`passport_data` AS `passport_data`,
	  `specialtie_student`.`group` AS `group`,
	  `specialtie_student`.`nuber_course` AS `nuber_course`,
	  `specialtie_student`.`number_record_book` AS `number_record_book`,
	  `specialtie_student`.`is_full_time` AS `is_full_time`,
	  `specialtie_student`.`date_receipt` AS `date_receipt`,
	  `specialtie_student`.`birthday` AS `birthday`,
	  `specialtie_student`.`describe` AS `describe`
	FROM `specialtie_student`
	WHERE (`specialtie_student`.`name_specialties` IN ('ММ', 'ПИ', 'БУ'));


/* Дни рождения студентов - birthday_students */
SELECT
  `students`.`name` AS `name`,
  `students`.`sex` AS `sex`,
  `students`.`parents` AS `parents`,
  `students`.`address` AS `address`,
  `students`.`phone_number` AS `phone_number`,
  `students`.`passport_data` AS `passport_data`,
  `students`.`group` AS `group`,
  `students`.`birthday` AS `birthday`,
  `students`.`date_receipt` AS `date_receipt`,
  `students`.`is_full_time` AS `is_full_time`,
  `students`.`number_record_book` AS `number_record_book`,
  `students`.`nuber_course` AS `nuber_course`
FROM `students`
WHERE (`students`.`birthday` BETWEEN '1981.01.01' AND '1983.12.31')


/* Сортированные студенты - sorted_student */
SELECT
  `students`.`name` AS `name`,
  `students`.`sex` AS `sex`,
  `students`.`parents` AS `parents`,
  `students`.`address` AS `address`,
  `students`.`phone_number` AS `phone_number`,
  `students`.`passport_data` AS `passport_data`,
  `students`.`group` AS `group`,
  `students`.`birthday` AS `birthday`,
  `students`.`date_receipt` AS `date_receipt`,
  `students`.`is_full_time` AS `is_full_time`,
  `students`.`number_record_book` AS `number_record_book`,
  `students`.`nuber_course` AS `nuber_course`
FROM `students`
ORDER BY `students`.`is_full_time`, `students`.`nuber_course` DESC


/*Обучающиеся очно - studying_full_time */
CREATE 
	DEFINER = 'root'@'localhost'
VIEW student.studying_full_time
AS
	SELECT
	  `students`.`name` AS `name`,
	  `students`.`sex` AS `sex`,
	  `students`.`birthday` AS `birthday`,
	  `students`.`date_receipt` AS `date_receipt`,
	  `students`.`number_record_book` AS `number_record_book`,
	  `students`.`group` AS `group`,
	  `students`.`nuber_course` AS `nuber_course`,
	  `students`.`is_full_time` AS `is_full_time`
	FROM `students`
	ORDER BY `students`.`name` DESC;


/* Студенты-москвичи с 1 родителем - moscow_students_one_parent */
CREATE 
	DEFINER = 'root'@'localhost'
VIEW student.moscow_students_one_parent
AS
	SELECT
	  `students`.`id` AS `id`,
	  `students`.`name` AS `name`,
	  `students`.`sex` AS `sex`,
	  `students`.`parents` AS `Родитель`,
	  `students`.`address` AS `address`,
	  `students`.`phone_number` AS `phone_number`,
	  `students`.`passport_data` AS `passport_data`,
	  `students`.`group` AS `group`,
	  `students`.`birthday` AS `birthday`,
	  `students`.`date_receipt` AS `date_receipt`,
	  `students`.`is_full_time` AS `is_full_time`,
	  `students`.`number_record_book` AS `number_record_book`,
	  `students`.`nuber_course` AS `nuber_course`,
	  `students`.`id_specialty` AS `id_specialty`
	FROM `students`;

/* Успеваемость студентов - students_marks */
CREATE 
	DEFINER = 'root'@'localhost'
VIEW student.students_marks
AS
	SELECT
	  `students`.`name` AS `students_name`,
	  `disciplines`.`name` AS `discipline_name`,
	  `exams`.`date` AS `date`,
	  `exams`.`mark` AS `mark`
	FROM ((`students`
	  JOIN `exams`
	    ON ((`exams`.`id_student` = `students`.`id`)))
	  JOIN `disciplines`
	    ON ((`exams`.`id_discipline` = `disciplines`.`id`)));