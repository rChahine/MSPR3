pipeline {
    agent any
    stages {
        stage('tests') {
            steps {
                bat '''
                    dotnet test
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
