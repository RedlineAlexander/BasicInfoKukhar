using System;
/*
��������: 0. 
1)� ����� ����������� � �� ������� ����� ������ �� ������� MVC
2)� ���������� ���� ������ News � ����������� ����� NewsBase �� ����� �������.
3)�������� NewsController.

4)� ���������� NewsController �������� action Index,
5)��� ��� ������ ������ ��������� ��� News �� NewsBase � ���� HTML �������.

6)�������� ������� �� �������� ������� � ��������� ������.
7)� ������� @RenderSection �������� ��� ������ � _Layout.
8)� navigation bar, ������� ��������� � ��� � _Layout(� �������������� ���� nav),
9)�������� ������� News,
10)��� ������� �� ���� �� ������ ������ ���������� � action Index
11)����������� News
12)� �������������� ����� ���������� ������� � ��������� �� �������� �������.
������ �� ���������
������� ��� �������� ���������, � ���������� � �������� � ����������
�� ������� ���������?
��� ������������ ��� �������� ������ �� ��������?
*/
namespace BasicInfoKukhar.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
