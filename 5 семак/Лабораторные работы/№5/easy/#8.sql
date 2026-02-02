



SELECT * FROM specialties
  WHERE `describe` LIKE "%информатика%" 


SELECT * FROM specialties
  WHERE `describe` REGEXP("^.*информатика.*$")
