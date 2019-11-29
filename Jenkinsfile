pipeline {
    agent any
    stages {
        stage("checkout") {
            steps {
                git 'https://github.com/mprattinger/JenkinsPipelineApp.git'
            }
        }
        stage("restore") {
            steps {
                sh 'sh restore.sh'
            }
        }
        stage('Build') {
            steps {
                sh 'sh build.sh'
            }
        }
        stage('Test') {
            steps {
                sh 'sh test.sh'
            }
        }
    }
    post {
        failure {
            mail bcc: '', body: "<b>Error</b><br>Project: ${env.JOB_NAME} <br>Build Number: ${env.BUILD_NUMBER} <br> Build: ${env.BUILD_URL} <br> $BUILD_LOG maxLines=8000, escapeHtml=true", cc: '', charset: 'UTF-8', from: '', mimeType: 'text/html', replyTo: '', subject: "ERROR CI: Project name -> ${env.JOB_NAME}", to: "mprattinger@outlook.com";
        }
    }
}
