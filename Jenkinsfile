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
                    sh 'dotnet restore'
                }
            }
            stage('Build') {
                steps {
                    sh 'sh build.sh'
                }
            }
            stage('Test') {
                steps {
                    sh 'test.sh'
                }
            }
        }
}
