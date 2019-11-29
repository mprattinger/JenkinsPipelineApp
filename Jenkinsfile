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
            def emailBody = '${SCRIPT, template="regressionfailed.groovy"}'
            def emailSubject = "${env.JOB_NAME} - Build# ${env.BUILD_NUMBER} - ${env.BUILD_STATUS}"
            emailext(mimeType: 'text/html', replyTo: 'xxxx', subject: emailSubject, to: 'xxxx', body: emailBody)
        }
    }
}
