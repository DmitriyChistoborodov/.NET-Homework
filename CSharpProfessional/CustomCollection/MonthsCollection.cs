using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollection
{
    // TASK 2: Создайте коллекцию, в которой бы хранились наименования 12 месяцев, порядковый номер и количество дней в
    // соответствующем месяце.Реализуйте возможность выбора месяцев, как по порядковому номеру, так и количеству дней в
    // месяце, при этом результатом может быть не только один месяц.
    public class MonthsCollection : IEnumerable<Month>
    {
        private Month[] months;

        public MonthsCollection()
        {
            months = new Month[12];

            for (int i = 0; i < 12; i++)
            {
                months[i] = InitMonth(i + 1);
            }
        }

        private Month InitMonth(int month)
        {
            return new Month(name: CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month), 
                serialNumber: month, 
                daysOfMonth: DateTime.DaysInMonth(DateTime.Now.Year, month));
        }

        public IEnumerable<Month> GetMonthsByDays(int days)
        {
            return months.Where(x => x.DaysOfMonth == days);
        }

        public Month GetMonth(int month)
        {
            return months.First(x => x.SerialNumber == month);
        }

        #region Enumerator

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public IEnumerator<Month> GetEnumerator() => new MonthsEnumerator(this);

        public class MonthsEnumerator : IEnumerator<Month>
        {
            private MonthsCollection collection;
            private int position = -1;

            public MonthsEnumerator(MonthsCollection collection)
            {
                this.collection = collection;
            }

            object IEnumerator.Current => Current;
            public Month Current
            {
                get
                {
                    return collection.months[position];
                }
            }

            public bool MoveNext()
            {
                return position++ < collection.months.Length - 1;
            }

            public void Reset()
            {
                position = -1;
            }

            public void Dispose()
            {
                
            }
        }

        #endregion
    }

    public struct Month
    {
        public string Name { get; }
        public int SerialNumber { get; }
        public int DaysOfMonth { get; }

        public Month(string name, int serialNumber, int daysOfMonth)
        {
            
            this.Name = name;
            this.SerialNumber = serialNumber;
            this.DaysOfMonth = daysOfMonth;
        }
    }
}
