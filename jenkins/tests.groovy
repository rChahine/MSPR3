pipeline {
    agent any
    stages {
        stage('tests') {
            steps {
                bat '''
                    dotnet tests
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
