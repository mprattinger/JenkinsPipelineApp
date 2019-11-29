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
                    sh label: '', script: 'restore.sh'
                }
            }
            stage('Build') {
                steps {
                    sh label: '', script: 'build.sh'
                }
            }
            stage('Test') {
                steps {
                    sh label: '', script: 'test.sh'
                }
            }
        }
}