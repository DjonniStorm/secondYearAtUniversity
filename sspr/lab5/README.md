# Скрипты и файлы для пятой лабораторной вариант 10
---
### Стэк: HTML, CSS, Bootstrap 5, JS, Express
## Или
### Версия arturverison.php на php 

## pipeline для jenkins
```
pipeline {
    agent any
    stages {
        stage('Pull Docker Image') {
            steps {
                script {
                    sh 'docker pull chillya/lab52'
                }
            }
        }
        stage('Run Tests') {
            steps {
                script {
                    sh '''
                    docker run --rm chillya/lab52 npm install
                    docker run --rm chillya/lab52 npm run test
                    '''
                }
            }
        }
    }
}
```
