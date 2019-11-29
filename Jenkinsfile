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
}
