﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7_ToDoList
{
    /*
    Задача:
    + Задача
    + Дата создания
    + Статус
     */

    public class Issue
    {
        public Issue()
        {
            CreationDate = DateTime.Now;
            Status = Status.New;
        }

        public string Title { get; set; }

        public DateTime CreationDate { get; set; }

        /// <summary>
        /// 1 - Новая
        /// 2 - Выполненая
        /// </summary>
        public Status Status { get; set; }
    }
}
