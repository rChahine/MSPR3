pipeline {
    agent any
    stages {
        stage('build') {
            steps {
                bat '''
                    dotnet build
                '''
            }
        }
    }
    post {
        always {
            echo 'Delete directory'
            deleteDir()
        }
    }
}
