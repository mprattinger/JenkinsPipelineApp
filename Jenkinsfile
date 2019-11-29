pipeline {
    agent any
    stages {
        stage("checkout") {
            steps {
                git credentialsId: 'mprattinger_github', url: 'https://github.com/mprattinger/JenkinsPipelineApp.git'
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
        stage('deploy') {
            steps {
                sh 'sh deploy.sh'
            }
        }
    }
    post {
        success {
            echo "Success!"
        }
        failure {
            step([$class: 'Mailer', recipients: emailextrecipients([[$class: 'CulpritsRecipientProvider']])])
        }
    }
}
