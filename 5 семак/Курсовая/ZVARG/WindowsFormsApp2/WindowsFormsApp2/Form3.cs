using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable resultTable = null;

            switch (comboBox1.SelectedIndex + 1)
            {
                case 1:
                    resultTable = Utils.executeGetQuerry("SELECT  m.код_мероприятия,\r\n        m.дата,\r\n        m.время,\r\n        m.название,\r\n        z.название       AS название_зала,\r\n        z.улица,\r\n        z.дом\r\nFROM    Мероприятие m\r\nJOIN    Зал z ON m.код_зала = z.код_зала\r\nORDER BY m.дата, m.время;\r\n");
                    break;
                case 2:
                    {
                        Dictionary<String, String> map = new Dictionary<String, String>();
                        map.Add("EventId", Utils.ShowInputDialog("Введите номер события:"));


                        resultTable = Utils.executeGetQuerry("SELECT  b.код_билета,\r\n        b.ряд,\r\n        b.сиденье,\r\n        b.стоимость\r\nFROM    Билет b\r\nLEFT JOIN Бронь br\r\n       ON br.код_билета = b.код_билета\r\n      AND br.статус = N'активна'\r\nWHERE   b.код_мероприятия = @EventId\r\n  AND   br.код_брони IS NULL;", map);
                    }
                    break;
                case 3:
                    {
                        Dictionary<String, String> map = new Dictionary<String, String>();
                        map.Add("Почта", Utils.ShowInputDialog("Введите почту:"));


                        resultTable = Utils.executeGetQuerry("DECLARE @Email NVARCHAR(100) = N'@Почта';\r\n\r\nSELECT  br.код_брони,\r\n        br.дата_создания,\r\n        br.время_создания,\r\n        br.статус,\r\n        br.комментарий,\r\n        m.название        AS мероприятие,\r\n        m.дата,\r\n        m.время,\r\n        b.ряд,\r\n        b.сиденье\r\nFROM    Покупатель p\r\nJOIN    Отзыв o           ON o.код_покупателя = p.код_покупателя\r\nJOIN    Отзыв_о_брони ob  ON ob.код_отзыва = o.код_отзыва\r\nJOIN    Бронь br          ON br.код_брони = ob.код_брони\r\nJOIN    Билет b           ON b.код_билета = br.код_билета\r\nJOIN    Мероприятие m     ON m.код_мероприятия = b.код_мероприятия\r\nWHERE   p.электронная_почта = @Email\r\nORDER BY br.дата_создания, br.время_создания;\r\n", map);
                    }
                    break;
                case 4:
                    {
                        Dictionary<String, String> map = new Dictionary<String, String>();
                        map.Add("TicketId", Utils.ShowInputDialog("Введите номер билета:"));
                        Utils.executeQuerry("\r\nINSERT INTO Бронь (\r\n    дата_создания, время_создания,\r\n    дата_истечения, время_истечения,\r\n    статус, комментарий, код_билета\r\n)\r\nVALUES (\r\n    CAST(GETDATE() AS DATE),\r\n    CONVERT(TIME(0), GETDATE()),\r\n    DATEADD(DAY, 3, CAST(GETDATE() AS DATE)),\r\n    '23:59:00',\r\n    N'активна',\r\n    N'Бронь через систему',\r\n    @TicketId\r\n);", map);
                    }

                    resultTable = Utils.executeGetQuerry("SELECT * FROM Бронь");
                    break;
                case 5:
                    resultTable = Utils.executeGetQuerry("SELECT  SUM(oпл.сумма) AS общая_выручка\r\nFROM    Оплата oпл\r\nJOIN    Бронь br ON br.код_брони = oпл.код_брони\r\nWHERE   br.статус IN (N'активна', N'завершена');\r\n");
                    break;
                case 6:
                    resultTable = Utils.executeGetQuerry("SELECT  m.код_мероприятия,\r\n        m.название,\r\n        m.дата,\r\n        m.время,\r\n        COUNT(b.код_билета)                                       AS всего_мест,\r\n        SUM(CASE WHEN br.статус IN (N'активна',N'завершена')\r\n                 THEN 1 ELSE 0 END)                               AS забронировано,\r\n        SUM(CASE WHEN br.код_брони IS NULL THEN 1 ELSE 0 END)     AS свободно,\r\n        SUM(CASE WHEN oпл.код_оплаты IS NOT NULL THEN 1 ELSE 0 END) AS продано\r\nFROM    Мероприятие m\r\nJOIN    Билет b\r\n          ON b.код_мероприятия = m.код_мероприятия\r\nLEFT JOIN Бронь br\r\n          ON br.код_билета = b.код_билета\r\nLEFT JOIN Оплата oпл\r\n          ON oпл.код_брони = br.код_брони\r\nGROUP BY m.код_мероприятия, m.название, m.дата, m.время\r\nORDER BY m.дата, m.время;\r\n");
                    break;
                case 7:
                    resultTable = Utils.executeGetQuerry("SELECT  br.*\r\nFROM    Бронь br\r\nLEFT JOIN Оплата oпл\r\n       ON oпл.код_брони = br.код_брони\r\nWHERE   oпл.код_оплаты IS NULL\r\n  AND   DATEADD(HOUR, 24,\r\n                CAST(br.дата_создания AS DATETIME)\r\n                + CAST(br.время_создания AS DATETIME)) < GETDATE();\r\n");
                    break;
                case 8:

                    {
                        Dictionary<String, String> map = new Dictionary<String, String>();
                        map.Add("BookingId", Utils.ShowInputDialog("Введите номер билета:"));
                        map.Add("Amount", Utils.ShowInputDialog("Введите колличество:"));
                        Utils.executeQuerry("INSERT INTO Оплата (\r\n    сумма,\r\n    дата_оплаты,\r\n    время_оплаты,\r\n    метод_оплаты,\r\n    подтверждение,\r\n    код_брони\r\n)\r\nVALUES (\r\n    @Amount,\r\n    CAST(GETDATE() AS DATE),\r\n    CONVERT(TIME(0), GETDATE()),\r\n    N'банковская карта',          -- или другой метод\r\n    N'PAY-' + FORMAT(@BookingId, '0000'),\r\n    @BookingId\r\n);", map);
                    }

                    resultTable = Utils.executeGetQuerry("SELECT * FROM Оплата");
                    break;
                case 9:
                    Utils.executeQuerry("UPDATE br\r\nSET    статус = N'завершена'\r\nFROM   Бронь br\r\nJOIN   Оплата oпл ON oпл.код_брони = br.код_брони\r\nWHERE  br.статус = N'активна';\r\n");

                    resultTable = Utils.executeGetQuerry("SELECT * FROM Бронь");

                    break;
                case 10:
                    resultTable = Utils.executeGetQuerry("SELECT TOP (1)\r\n       m.код_мероприятия,\r\n       m.название,\r\n       COUNT(DISTINCT b.код_билета) AS продано\r\nFROM   Мероприятие m\r\nJOIN   Билет b        ON b.код_мероприятия = m.код_мероприятия\r\nJOIN   Бронь br       ON br.код_билета = b.код_билета\r\nJOIN   Оплата oпл     ON oпл.код_брони = br.код_брони\r\nGROUP BY m.код_мероприятия, m.название\r\nORDER BY продано DESC;\r\n");

                    break;
                case 11:

                    {
                        Dictionary<String, String> map = new Dictionary<String, String>();
                        map.Add("EventId2", Utils.ShowInputDialog("Введите номер события:"));


                        resultTable = Utils.executeGetQuerry("\r\nSELECT DISTINCT\r\n       p.код_покупателя,\r\n       p.фамилия,\r\n       p.имя,\r\n       p.электронная_почта\r\nFROM   Покупатель p\r\nJOIN   Отзыв o           ON o.код_покупателя = p.код_покупателя\r\nJOIN   Отзыв_о_брони ob  ON ob.код_отзыва = o.код_отзыва\r\nJOIN   Бронь br          ON br.код_брони = ob.код_брони\r\nJOIN   Оплата oпл        ON oпл.код_брони = br.код_брони\r\nJOIN   Билет b           ON b.код_билета = br.код_билета\r\nWHERE  b.код_мероприятия = @EventId2;", map);
                    }

                    break;
                case 12:
                    resultTable = Utils.executeGetQuerry("SELECT  m.категория,\r\n        AVG(b.стоимость) AS средняя_цена\r\nFROM    Мероприятие m\r\nJOIN    Билет b ON b.код_мероприятия = m.код_мероприятия\r\nGROUP BY m.категория;\r\n");

                    break;
                case 13:

                    {
                        Dictionary<String, String> map = new Dictionary<String, String>();
                        map.Add("BookingId", Utils.ShowInputDialog("Введите номер билета:"));
                        Utils.executeQuerry("UPDATE Бронь\r\nSET    статус = N'отменена'\r\nWHERE  код_брони = @BookingId;", map);
                    }

                    resultTable = Utils.executeGetQuerry("SELECT * FROM Бронь");

                    break;
                case 14:
                    resultTable = Utils.executeGetQuerry("SELECT *\r\nFROM   Мероприятие\r\nWHERE  дата BETWEEN CAST(GETDATE() AS DATE)\r\n                AND DATEADD(DAY, 7, CAST(GETDATE() AS DATE))\r\nORDER BY дата, время;\r\n");
                    break;
                case 15:
                    resultTable = Utils.executeGetQuerry("SELECT  br.код_билета,\r\n        COUNT(*) AS кол_во_бронирований\r\nFROM    Бронь br\r\nGROUP BY br.код_билета\r\nHAVING COUNT(*) > 1;\r\n");
                    break;
                case 16:
                    resultTable = Utils.executeGetQuerry("SELECT  m.код_мероприятия,\r\n        m.название,\r\n        COUNT(b.код_билета) AS всего_мест,\r\n        COUNT(DISTINCT b2.код_билета) AS продано,\r\n        100.0 * COUNT(DISTINCT b2.код_билета) /\r\n        NULLIF(COUNT(b.код_билета),0) AS заполненность_процентов\r\nFROM    Мероприятие m\r\nJOIN    Билет b\r\n          ON b.код_мероприятия = m.код_мероприятия\r\nLEFT JOIN (\r\n        SELECT DISTINCT b.код_билета\r\n        FROM   Билет b\r\n        JOIN   Бронь br   ON br.код_билета = b.код_билета\r\n        JOIN   Оплата oпл ON oпл.код_брони = br.код_брони\r\n) b2 ON b2.код_билета = b.код_билета\r\nGROUP BY m.код_мероприятия, m.название;\r\n");
                    break;
                case 17:
                    resultTable = Utils.executeGetQuerry("SELECT TOP (1) *\r\nFROM   Билет\r\nORDER BY стоимость DESC;\r\n");
                    break;
                case 18:
                    {
                        Dictionary<String, String> map = new Dictionary<String, String>();
                        map.Add("Почта", Utils.ShowInputDialog("Введите почту:"));


                        resultTable = Utils.executeGetQuerry("DECLARE @ClientEmail NVARCHAR(100) = N'@Почта';\r\n\r\nSELECT  oпл.код_оплаты,\r\n        oпл.дата_оплаты,\r\n        oпл.время_оплаты,\r\n        oпл.сумма,\r\n        m.название      AS мероприятие,\r\n        m.дата,\r\n        m.время,\r\n        b.ряд,\r\n        b.сиденье\r\nFROM    Покупатель p\r\nJOIN    Отзыв o           ON o.код_покупателя = p.код_покупателя\r\nJOIN    Отзыв_о_брони ob  ON ob.код_отзыва = o.код_отзыва\r\nJOIN    Бронь br          ON br.код_брони = ob.код_брони\r\nJOIN    Оплата oпл        ON oпл.код_брони = br.код_брони\r\nJOIN    Билет b           ON b.код_билета = br.код_билета\r\nJOIN    Мероприятие m     ON m.код_мероприятия = b.код_мероприятия\r\nWHERE   p.электронная_почта = @ClientEmail\r\nORDER BY oпл.дата_оплаты, oпл.время_оплаты;\r\n", map);
                    }
                    break;
                default:
                    break;
            }

            this.dataGridView1.DataSource = resultTable.DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
