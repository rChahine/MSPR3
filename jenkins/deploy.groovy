pipeline {
    agent any
    stages {
        stage('generate a release exe file') {
            steps {
                bat '''
                    dotnet build --configuration Release
                '''
            }
        }
        stage('Pack all files in portable directory') {
            steps {
                bat '''
                    mkdir .\\v1.2.3
                    move .\\MSPR3.App\\bin\\Release\\netcoreapp3.1\\* .\\v1.2.3\
                '''
            }
        }
        stage('Send folder to git') {
            steps {
                bat '''
                    git remote set-url origin git@github.com:rChahine/MSPR3.git
                    git config --global user.email "pierrick38800@gmail.com"
                    git config --global user.name "Pierrick-Loiacono"
                    git checkout -b "version-1-2-3"
                    git rm -r --cached .
                    git add v1.2.3
                    git commit -m "🔖 v1.2.3"
                    git push origin version-1-2-3
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
