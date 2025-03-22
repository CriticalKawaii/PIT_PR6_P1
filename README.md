# PIT_PR6_P1_Sargas_122

## Работа приложения

![image](https://github.com/user-attachments/assets/ee5194d1-6c4a-4666-b937-694b784d4b49)

## Результаты выполнения тестов

![image](https://github.com/user-attachments/assets/b58b2031-72ee-482d-bd40-cb8db63fe644)

## Вывод о проведенном тестировании

Результаты тестирования показали, что все тесты были успешно пройдены. В частности:

-  Тесты дебетовых операций проверили корректное обновление баланса при списании допустимых сумм, а также корректное выбрасывание исключений при попытке списания отрицательной суммы или суммы, превышающей баланс.
-  Тесты кредитных операций подтвердили корректное увеличение баланса при пополнении счета и правильную обработку ошибок при попытке внесения отрицательной суммы.

### Все тесты прошли успешно, что говорит о правильной работе системы банковских операций

* ✅ Реализация класса `BankAccount` соответствует ожидаемому поведению.
* ✅ Исключения корректно выбрасываются в предусмотренных ситуациях.
* ✅ Баланс обновляется в соответствии с бизнес-логикой.
