# ᗜˬᗜ Настольная карточная компьютерная игра ᗜˬᗜ
![video (1)](https://user-images.githubusercontent.com/80702083/224549826-767439ac-d55a-4d95-ae4c-fda357c94378.gif)
## Назначение системы
Наша система позволяет игрокам настроить правила игры, выбрать режим игры, соревноваться с другими игроками и наслаждаться реалистичной игровой атмосферой. Она также предлагает множество вариантов настроек игры, достижений и бонусов за выполнение задач, а также возможность сохранять и возобновлять игру в любой момент. И предоставляет игрокам удобный и увлекательный способ игры в эту популярную карточную игру.

## User stories
1. Как игрок, я хочу иметь возможность сохранять свои рекорды и видеть статистику, чтобы я могу наблюдать за своим развитием и прогрессом в игре.

2. Как игрок, я хочу, чтобы я мог легко настроить игру и выбрать правила, чтобы настраивать игру под свои желания без особого труда.

3. Как игрок, я хочу, чтобы игра имела несколько режимов, включая одиночную игру, игру с друзьями и онлайн-игру, чтобы играть при разных ситуациях и условиях.

4. Как игрок, я хочу, чтобы игра включала анимацию карт, чтобы мне было приятно наблюдать за игровым процессом.

5. Как игрок, я хочу иметь выбор звуковых эффектов и музыки, чтобы было приятнее погрузиться в игровой процесс.

6. Как игрок, я хочу иметь возможность взаимодействовать с другими игроками в виде небольших стикеров, чтобы делиться эмоциями с партнерами и видеть их реакцию.

7. Как игрок, я хочу, чтобы игра предлагала достижения за выполнение определённых задач, чтобы я мог чувствовать себя более мотивированным и увлеченным игроком.

8. Как игрок, я хочу иметь возможность кастомизировать свою колоду и/или игровое поле, чтобы настроить игру под свои вкусы и желания.

9. Как игрок, я хочу, иметь возможность добавлять друзей, чтобы я мог отслеживать их статистику.

10. Как игрок, я хочу иметь возможность пройти обучение и прочитать информацию обо всех имеющихся картах и правилах, чтобы быстро влиться в игровой процесс.  

## Функциональные требования
1. Игрок должен иметь возможность вводить свой логин и пароль в специальные поля, а так же сохранять свою учетную запись.

2. Игрок должен иметь доступ к настройкам на главном экране и на игровом поле, а также иметь интуитивно понятный интерфейс с основными настройками.

3. Игрок должен иметь возможность поиграть как с ботами, так и с реальными людьми, причем одиночная игра должна быть доступна без подключения к интернету.

4. Игрок должен иметь возможность зайти в игру в любой момент.

5. Игрок должен иметь возможность изменить фоновую музыку или звуковые эффекты в настройках.

6. Игрок должен иметь возможность показать реакцию в виде стикера во время игры, стикеры могут быть 4-х видов (Палец вверх, Палец вниз, Улыбающийся смайлик и Грустный смайлик).

7. Игрок должен иметь возможность получить достижения за определенное количество побед и за первую победу.

8. Игрок должен иметь возможность изменить дизайн игрового поля или карт на встроенные скины.

9. Игрок должен иметь возможность добавлять друзей с помощью поиска по id и просматривать их профили, где мог бы видеть их достижения

10. Игрок должен иметь возможность пройти обучение, которое можно активировать при первом запуске игры или через панель настроек и с помощью неё возвращаться к подсказкам, которые расскажут про механику игры, правила и возможности кастомизации.

## Портрет пользователя
**Имя:** Александр

**Возраст:** 19

**Место проживания:** Саратов

**Семейное положение, количество детей:** холост, детей нет

**Сфера занятости и уровень зарплаты:** студент, стипендия 3000 рублей

**Потребности, желания, фобии:** когда Саше скучно на лекциях, он хочет отвлечься и немного поиграть, причем иногда он хочет поиграть вместе со своими одногруппниками

## Use case диаграмма
![use_case](https://user-images.githubusercontent.com/80702083/222981384-89fd3dd2-1e15-4f47-9e67-d7a107273e61.png)

## Диаграмма взаимодействия
![aris_](https://user-images.githubusercontent.com/80702083/224488040-6e29ef23-6608-4811-af2f-cc2357e28249.png)

## Нефункциональные требования
Тип требования | Содержание требования|
---------------|----------------------|
**Технические ограничения**| Приложение должно запускаться на Windows 8/10/11;  Необходимые устройства ввода клавиатура и компьютерная мышь/тачпад|
**Производительность**| Приложение должно стабильно работать при 4-х одновременно подключенных пользователей; Приложение должно задействовать не больше 500Mb оперативной памяти; Приложение должно задействовать не больше 500Mb видеопамяти  |
**Масштабируемость**| |
**Надежность**| Приложение должно сохранять данные и прогресс пользователя; Приложение должно запускаться без подключения к интернету (если только пользователь не решит сыграть в онлайн режим)|
**Безопасность**| Приложение должно хранить пароли пользователей в зашифрованном виде; Приложение должно иметь защиту от взлома, для предотвращения нарушения игрового процесса; Передача данных по сети должна быть защищена|

## Матрица требований
№ | Требование | Суть | Автор | Ссылки | Критерий проверки 
--|------------|------|-------|--------|-------------------
1| Регистрация пользователя| Приложение должно иметь функцию регистрации нового пользователя| Шушков С.М.| https://habr.com/ru/company/infopulse/blog/346318/| Регистрация нового пользователя| 
2| Настройка игры| Приложение должно иметь раздел с настройками и кастомизацией игры| Федотов В.А.| https://habr.com/ru/post/346370/| Возможность настроить игру| 
3| Отслеживание достижений| Приложение должно иметь функцию поощрения действий пользователя| Федотов В.А.| https://dtf.ru/flood/670347-dostizheniya-v-videoigrah-zachem-ih-vybivayut| Уведомление о правильном выполнении последовательности действий| 
4| Музыкальное сопровождение геймплея| Музыка должна создать определенную атмосферу в игре| Шушков С.М.| https://dtf.ru/games/622890-rol-muzyki-v-videoigrah-osnovy-chast-1| Во время игры воспроизводится приятные саундтреки| 
5| Возможность оставлять реакции| Пользователь должен иметь возможность оставить реакцию-стикер во время игры| Шушков С.М.| https://dtf.ru/gamedev/1053552-vnutriigrovye-emodzi-kak-my-sozdaem-animacii-dlya-rush-royale| Оставить стикер во время удачного сброса карт| 
6| Обучение геймплею| Приложение должно иметь обучение, которое расскажет про механику игры, правила и возможности кастомизации| Федотов В.А.| https://dtf.ru/gamedev/704380-nenavyazchivoe-obuchenie-kak-sozdat-tutorial-kotoryy-ne-ottolknet-igroka| Обучение показало игровые механики и рассказало о правилах игры и возможностях кастомизации
7| Ограничение потребления памяти| Игра не должна потреблять больше 500Мб оперативной памяти| Шушков С.М.| https://habr.com/ru/post/344822/| Проверка потребления памяти на бенчмарке
8| Защита паролей пользователей| Пароли от учеток пользователей должны храниться в зашифрованном виде| Шушков С.М.| https://habr.com/ru/company/acribia/blog/413157/| Посмотреть как хранятся пароли|  
9| Защита игрового процесса| Игра должна иметь простые алгоритмы противодействующие взлому| Федотов В.А.| https://habr.com/ru/post/249681/ https://dtf.ru/indie/947749-zashchita-ot-chiterov-na-primerah-besplatnaya-biblioteka-ot-pixel-incubator| Попробовать взломать игру простыми программами
10| 










