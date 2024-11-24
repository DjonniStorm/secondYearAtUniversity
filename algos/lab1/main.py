import pandas as pd
from sklearn.model_selection import train_test_split
from sklearn.feature_extraction.text import TfidfVectorizer
from sklearn.naive_bayes import MultinomialNB
from sklearn.pipeline import Pipeline
from sklearn.multioutput import MultiOutputClassifier

# Загрузка данных
df = pd.read_csv("./L.csv", sep=";", encoding='latin1')
#замена пустых элементов на пустые строчки 
df = df.fillna('')
# 'Group' и 'Cat' являются целевыми переменными
X = df['Desc']  # Тексты заявок
y = df[['Group', 'Cat']]  # Группы и категории

# Разделение данных на обучающую и тестовую выборки
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=42)

# Создание модели с использованием Pipeline
model = Pipeline([
    ('tfidf', TfidfVectorizer()),  # Преобразование текста в векторное представление, TF-IDF(выделяет важные слова в тексте)
    ('classifier', MultiOutputClassifier(MultinomialNB()))  # Вероятность классификации 
])


# Обучение модели
model.fit(X_train, y_train)

# Загрузка новых данных
new_data = pd.read_csv("./C.csv", sep=";", encoding='latin1')

# Применение модели к новым данным
predictions = model.predict(new_data['Desc'])

# Заполнение столбцов 'Group' и 'Cat' в новых данных
new_data['Group'] = predictions[:, 0]
new_data['Cat'] = predictions[:, 1]

# Сохранение результатов в файл A.csv
new_data.to_csv("./A.csv", sep=";", encoding='latin1', index=False)

print("Классификация завершена, результаты сохранены в A.csv.")